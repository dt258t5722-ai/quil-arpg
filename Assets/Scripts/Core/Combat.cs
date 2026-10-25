using System;
using UnityEngine;

namespace Quil
{
    /// <summary>A single hit. Damage is rolled from a min/max range with a crit chance.</summary>
    public struct DamageInfo
    {
        public float Amount;
        public bool IsCrit;
        public Vector3 Point;
        public Vector3 Direction;
        public GameObject Source;
        public float Knockback;

        public static DamageInfo Roll(float min, float max, float critChance, float critMultiplier,
            GameObject source, Vector3 point, Vector3 dir, float knockback = 0f)
        {
            bool crit = UnityEngine.Random.value < critChance;
            float amount = UnityEngine.Random.Range(min, max);
            if (crit) amount *= critMultiplier;
            return new DamageInfo
            {
                Amount = Mathf.Round(amount),
                IsCrit = crit,
                Point = point,
                Direction = dir,
                Source = source,
                Knockback = knockback
            };
        }
    }

    /// <summary>Health component shared by player and goblins.</summary>
    public class Health : MonoBehaviour
    {
        public float maxHealth = 100f;
        public float current;
        public bool invulnerable;
        public bool showDamageNumbers = true;
        public Color damageColor = Color.white;

        public event Action<DamageInfo> Damaged;
        public event Action Died;

        public bool IsDead => current <= 0f;
        public float Normalized => maxHealth > 0f ? current / maxHealth : 0f;

        void Awake() { current = maxHealth; }

        public bool TakeDamage(DamageInfo info)
        {
            if (IsDead || invulnerable) return false;
            current = Mathf.Max(0f, current - info.Amount);
            if (showDamageNumbers)
                DamageNumbers.Spawn(transform.position + Vector3.up * 2f, info.Amount, info.IsCrit, damageColor);
            Damaged?.Invoke(info);
            if (current <= 0f) Died?.Invoke();
            return true;
        }

        public void Heal(float amount)
        {
            if (IsDead) return;
            current = Mathf.Min(maxHealth, current + amount);
            DamageNumbers.Spawn(transform.position + Vector3.up * 2f, amount, false, new Color(0.4f, 1f, 0.4f), "+");
        }
    }

    /// <summary>Utility for melee arc hit detection.</summary>
    public static class MeleeUtil
    {
        static readonly Collider[] Buffer = new Collider[32];

        /// <summary>Returns number of targets hit. Calls onHit for each Health in a forward arc.</summary>
        public static int HitArc(Transform attacker, float range, float arcDegrees, LayerMask mask,
            Func<Health, DamageInfo> makeDamage, Func<Health, bool> filter = null)
        {
            Vector3 origin = attacker.position + Vector3.up;
            int n = Physics.OverlapSphereNonAlloc(origin, range, Buffer, mask, QueryTriggerInteraction.Ignore);
            int hits = 0;
            for (int i = 0; i < n; i++)
            {
                var h = Buffer[i].GetComponentInParent<Health>();
                if (h == null || h.gameObject == attacker.gameObject || h.IsDead) continue;
                if (filter != null && !filter(h)) continue;
                Vector3 to = h.transform.position - attacker.position; to.y = 0f;
                if (to.sqrMagnitude > 0.01f && Vector3.Angle(attacker.forward, to) > arcDegrees * 0.5f) continue;
                if (h.TakeDamage(makeDamage(h))) hits++;
            }
            return hits;
        }
    }
}
