using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Quil
{
    /// <summary>
    /// Quil Ashby: hatchet light combo, heavy chop, dodge roll with i-frames, health potions.
    /// </summary>
    [RequireComponent(typeof(CharacterController), typeof(Health))]
    public class PlayerController : MonoBehaviour
    {
        [Header("Movement")]
        public float moveSpeed = 6f;
        public float turnSpeed = 900f;
        public float gravity = -25f;
        [Tooltip("Camera yaw used to make stick input camera-relative (isometric = 45).")]
        public float cameraYaw = 45f;

        [Header("Stamina")]
        public float maxStamina = 100f;
        public float stamina;
        public float staminaRegen = 28f;
        public float staminaRegenDelay = 0.6f;

        [Header("Light attack (hatchet combo)")]
        public float lightCost = 12f;
        public Vector2 lightDamage = new Vector2(10f, 16f);
        public float[] comboDurations = { 0.38f, 0.38f, 0.55f };
        public float comboWindow = 0.35f;
        public float lightRange = 2.2f;

        [Header("Heavy attack")]
        public float heavyCost = 30f;
        public Vector2 heavyDamage = new Vector2(28f, 40f);
        public float heavyWindup = 0.45f;
        public float heavyRecovery = 0.45f;
        public float heavyRange = 2.6f;

        [Header("Crits")]
        [Range(0, 1)] public float critChance = 0.15f;
        public float critMultiplier = 2f;

        [Header("Dodge")]
        public float dodgeCost = 25f;
        public float dodgeDistance = 5f;
        public float dodgeDuration = 0.35f;
        public float iFrameStart = 0.02f, iFrameEnd = 0.3f;

        [Header("Potions")]
        public int potions = 3;
        public int maxPotions = 5;
        public float potionHeal = 45f;
        public float potionCooldown = 1.0f;

        public LayerMask hitMask = ~0;

        public Health Health { get; private set; }
        public float StaminaNormalized => stamina / maxStamina;
        public bool IsBusy => busy;

        CharacterController cc;
        QuilInput input;
        Transform visual;
        bool busy;
        float verticalVel;
        float lastStaminaUse;
        float lastPotion = -10f;
        int comboIndex;
        bool queuedLight;
        Vector3 lastMoveDir = Vector3.forward;

        void Awake()
        {
            cc = GetComponent<CharacterController>();
            Health = GetComponent<Health>();
            stamina = maxStamina;
            visual = transform.Find("Visual");
            Health.Damaged += OnDamaged;
            Health.Died += OnDied;
        }

        void OnEnable() { input = new QuilInput(); }
        void OnDisable() { input?.Dispose(); input = null; }

        void Update()
        {
            if (Health.IsDead || input == null) return;
            input.UpdateDevice();

            // Stamina regen
            if (Time.time - lastStaminaUse > staminaRegenDelay)
                stamina = Mathf.Min(maxStamina, stamina + staminaRegen * Time.deltaTime);

            Vector3 move = CameraRelative(input.Move.ReadValue<Vector2>());
            if (move.sqrMagnitude > 0.01f) lastMoveDir = move.normalized;

            if (!busy)
            {
                Vector3 vel = move * moveSpeed;
                ApplyGravity(ref vel);
                cc.Move(vel * Time.deltaTime);
                FaceAim(move);

                if (input.Dodge.WasPressedThisFrame() && TrySpend(dodgeCost)) StartCoroutine(DodgeRoutine(move));
                else if (input.Heavy.WasPressedThisFrame() && TrySpend(heavyCost)) StartCoroutine(HeavyRoutine());
                else if (input.Light.WasPressedThisFrame() && TrySpend(lightCost)) StartCoroutine(LightComboRoutine());
            }
            else
            {
                Vector3 vel = Vector3.zero;
                ApplyGravity(ref vel);
                cc.Move(vel * Time.deltaTime);
                if (input.Light.WasPressedThisFrame()) queuedLight = true;
            }

            if (input.Potion.WasPressedThisFrame()) TryDrinkPotion();
        }

        Vector3 CameraRelative(Vector2 v)
        {
            if (v.sqrMagnitude < 0.02f) return Vector3.zero;
            var dir = Quaternion.Euler(0f, cameraYaw, 0f) * new Vector3(v.x, 0f, v.y);
            return Vector3.ClampMagnitude(dir, 1f);
        }

        void ApplyGravity(ref Vector3 vel)
        {
            if (cc.isGrounded && verticalVel < 0f) verticalVel = -2f;
            verticalVel += gravity * Time.deltaTime;
            vel.y = verticalVel;
        }

        /// <summary>Right stick aims; otherwise mouse cursor; otherwise movement direction.</summary>
        void FaceAim(Vector3 move, bool instant = false)
        {
            Vector3 aim = Vector3.zero;
            Vector2 stick = input.Aim.ReadValue<Vector2>();
            if (stick.sqrMagnitude > 0.09f) aim = CameraRelative(stick);
            else if (!input.UsingGamepad && Mouse.current != null && Camera.main != null)
            {
                Ray r = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
                var plane = new Plane(Vector3.up, transform.position);
                if (plane.Raycast(r, out float d))
                {
                    aim = r.GetPoint(d) - transform.position; aim.y = 0f;
                }
            }
            else if (move.sqrMagnitude > 0.01f) aim = move;

            if (aim.sqrMagnitude < 0.01f) return;
            var target = Quaternion.LookRotation(aim.normalized, Vector3.up);
            transform.rotation = instant ? target : Quaternion.RotateTowards(transform.rotation, target, turnSpeed * Time.deltaTime);
        }

        bool TrySpend(float cost)
        {
            if (stamina < cost * 0.5f) return false; // allow going slightly into the red, Diablo-style leniency
            stamina = Mathf.Max(0f, stamina - cost);
            lastStaminaUse = Time.time;
            return true;
        }

        IEnumerator LightComboRoutine()
        {
            busy = true;
            comboIndex = 0;
            while (true)
            {
                queuedLight = false;
                FaceAim(lastMoveDir, true);
                float dur = comboDurations[Mathf.Min(comboIndex, comboDurations.Length - 1)];
                bool finisher = comboIndex == comboDurations.Length - 1;
                yield return Swing(dur * 0.4f, finisher ? 30f : (comboIndex == 0 ? -60f : 60f));
                float mult = finisher ? 1.5f : 1f;
                int hits = MeleeUtil.HitArc(transform, lightRange, finisher ? 200f : 120f, hitMask,
                    h => DamageInfo.Roll(lightDamage.x * mult, lightDamage.y * mult, critChance, critMultiplier,
                        gameObject, h.transform.position, transform.forward, finisher ? 6f : 2.5f));
                if (hits > 0) { input.Rumble(0.2f, 0.4f, 0.08f, this); StartCoroutine(HitStop(0.04f)); }
                yield return new WaitForSeconds(dur * 0.6f);

                // Combo window
                float t = 0f;
                while (t < comboWindow && !queuedLight) { t += Time.deltaTime; yield return null; }
                comboIndex++;
                if (!queuedLight || comboIndex >= comboDurations.Length || !TrySpend(lightCost)) break;
            }
            ResetVisual();
            busy = false;
        }

        IEnumerator HeavyRoutine()
        {
            busy = true;
            FaceAim(lastMoveDir, true);
            yield return Swing(heavyWindup, 0f, overhead: true);
            int hits = MeleeUtil.HitArc(transform, heavyRange, 150f, hitMask,
                h => DamageInfo.Roll(heavyDamage.x, heavyDamage.y, critChance + 0.1f, critMultiplier,
                    gameObject, h.transform.position, transform.forward, 9f));
            if (hits > 0) { input.Rumble(0.6f, 0.8f, 0.15f, this); StartCoroutine(HitStop(0.08f)); }
            yield return new WaitForSeconds(heavyRecovery);
            ResetVisual();
            busy = false;
        }

        IEnumerator DodgeRoutine(Vector3 move)
        {
            busy = true;
            Vector3 dir = move.sqrMagnitude > 0.01f ? move.normalized : -transform.forward;
            transform.rotation = Quaternion.LookRotation(dir);
            float t = 0f;
            float speed = dodgeDistance / dodgeDuration;
            while (t < dodgeDuration)
            {
                t += Time.deltaTime;
                Health.invulnerable = t >= iFrameStart && t <= iFrameEnd;
                if (visual) visual.localRotation = Quaternion.Euler(360f * (t / dodgeDuration), 0f, 0f);
                Vector3 v = dir * speed; ApplyGravity(ref v);
                cc.Move(v * Time.deltaTime);
                yield return null;
            }
            Health.invulnerable = false;
            ResetVisual();
            busy = false;
        }

        /// <summary>Placeholder "animation": tilt the capsule visual and swing the hatchet pivot.</summary>
        IEnumerator Swing(float windup, float yawFrom, bool overhead = false)
        {
            var hatchet = transform.Find("Visual/HatchetPivot");
            float t = 0f;
            while (t < windup)
            {
                t += Time.deltaTime;
                float k = t / windup;
                if (hatchet)
                    hatchet.localRotation = overhead
                        ? Quaternion.Euler(Mathf.Lerp(-120f, 60f, k * k), 0f, 0f)
                        : Quaternion.Euler(20f, Mathf.Lerp(yawFrom, -yawFrom, k), 0f);
                yield return null;
            }
        }

        void ResetVisual()
        {
            if (visual) visual.localRotation = Quaternion.identity;
            var hatchet = transform.Find("Visual/HatchetPivot");
            if (hatchet) hatchet.localRotation = Quaternion.identity;
        }

        static IEnumerator HitStop(float d)
        {
            Time.timeScale = 0.05f;
            yield return new WaitForSecondsRealtime(d);
            Time.timeScale = 1f;
        }

        void TryDrinkPotion()
        {
            if (potions <= 0 || Time.time - lastPotion < potionCooldown || Health.current >= Health.maxHealth) return;
            potions--;
            lastPotion = Time.time;
            Health.Heal(potionHeal);
        }

        public void AddPotion() { potions = Mathf.Min(maxPotions, potions + 1); }

        void OnDamaged(DamageInfo info)
        {
            input?.Rumble(0.5f, 0.2f, 0.12f, this);
            if (info.Knockback > 0f && !busy)
            {
                Vector3 kb = info.Direction; kb.y = 0f;
                cc.Move(kb.normalized * info.Knockback * 0.05f);
            }
        }

        void OnDied()
        {
            StopAllCoroutines();
            Time.timeScale = 1f;
            busy = true;
            if (visual) visual.localRotation = Quaternion.Euler(90f, 0f, 0f);
            input?.Rumble(1f, 1f, 0.4f, this);
        }

        public void Respawn(Vector3 position)
        {
            cc.enabled = false;
            transform.position = position;
            cc.enabled = true;
            Health.current = Health.maxHealth;
            stamina = maxStamina;
            potions = Mathf.Max(potions, 3);
            busy = false;
            ResetVisual();
        }
    }
}
