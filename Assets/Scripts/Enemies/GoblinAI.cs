using System;
using UnityEngine;
using UnityEngine.AI;

namespace Quil
{
    /// <summary>Goblin cutter: Idle -> Chase -> Attack, with HitReact and Death. Built on NavMeshAgent.</summary>
    [RequireComponent(typeof(NavMeshAgent), typeof(Health))]
    public class GoblinAI : MonoBehaviour
    {
        public enum State { Idle, Chase, Attack, HitReact, Dead }

        public State state = State.Idle;
        public float aggroRange = 14f;
        public float leashRange = 26f;
        public float attackRange = 1.8f;
        public float attackWindup = 0.5f;     // telegraph: goblin flashes before the slash lands
        public float attackRecovery = 0.7f;
        public float attackCooldown = 0.6f;
        public Vector2 damage = new Vector2(6f, 11f);
        [Range(0, 1)] public float critChance = 0.1f;
        public float critMultiplier = 1.75f;
        public float hitReactTime = 0.35f;
        public float corpseTime = 4f;
        [Range(0, 1)] public float potionDropChance = 0.2f;

        public event Action<GoblinAI> OnDeath;

        NavMeshAgent agent;
        Health health;
        Transform player;
        Health playerHealth;
        Renderer body;
        Color baseColor;
        float stateTimer;
        float lastAttack = -10f;
        bool attackLanded;
        Vector3 knockVel;

        void Awake()
        {
            agent = GetComponent<NavMeshAgent>();
            health = GetComponent<Health>();
            body = GetComponentInChildren<Renderer>();
            if (body) baseColor = body.material.color;
            health.Damaged += OnDamaged;
            health.Died += OnDied;
        }

        void Start()
        {
            var p = FindFirstObjectByType<PlayerController>();
            if (p) { player = p.transform; playerHealth = p.Health; }
        }

        void Update()
        {
            if (state == State.Dead) { stateTimer += Time.deltaTime; if (stateTimer > corpseTime) Destroy(gameObject); return; }
            if (player == null || !agent.isOnNavMesh) return;

            if (knockVel.sqrMagnitude > 0.01f)
            {
                agent.Move(knockVel * Time.deltaTime);
                knockVel = Vector3.Lerp(knockVel, Vector3.zero, 10f * Time.deltaTime);
            }

            float dist = Vector3.Distance(transform.position, player.position);
            bool playerAlive = playerHealth != null && !playerHealth.IsDead;
            stateTimer += Time.deltaTime;

            switch (state)
            {
                case State.Idle:
                    agent.isStopped = true;
                    if (playerAlive && dist < aggroRange) Enter(State.Chase);
                    break;

                case State.Chase:
                    agent.isStopped = false;
                    agent.SetDestination(player.position);
                    if (!playerAlive || dist > leashRange) Enter(State.Idle);
                    else if (dist <= attackRange && Time.time - lastAttack > attackCooldown) Enter(State.Attack);
                    break;

                case State.Attack:
                    agent.isStopped = true;
                    if (stateTimer < attackWindup)
                    {
                        Face(player.position, 540f);
                        Flash(Color.Lerp(baseColor, new Color(1f, 0.3f, 0.1f), stateTimer / attackWindup));
                    }
                    else if (!attackLanded)
                    {
                        attackLanded = true;
                        Flash(baseColor);
                        MeleeUtil.HitArc(transform, attackRange + 0.4f, 100f, ~0, h =>
                            DamageInfo.Roll(damage.x, damage.y, critChance, critMultiplier, gameObject,
                                h.transform.position, transform.forward, 3f),
                            h => h.GetComponent<PlayerController>() != null);
                        lastAttack = Time.time;
                    }
                    else if (stateTimer > attackWindup + attackRecovery) Enter(State.Chase);
                    break;

                case State.HitReact:
                    agent.isStopped = true;
                    if (stateTimer > hitReactTime) { Flash(baseColor); Enter(State.Chase); }
                    break;
            }
        }

        void Enter(State s)
        {
            state = s;
            stateTimer = 0f;
            attackLanded = false;
        }

        void Face(Vector3 target, float speed)
        {
            Vector3 d = target - transform.position; d.y = 0f;
            if (d.sqrMagnitude < 0.001f) return;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(d), speed * Time.deltaTime);
        }

        void Flash(Color c) { if (body) body.material.color = c; }

        void OnDamaged(DamageInfo info)
        {
            if (state == State.Dead) return;
            Vector3 dir = info.Direction; dir.y = 0f;
            knockVel = dir.normalized * info.Knockback;
            Flash(Color.white);
            // Heavy or crit hits interrupt even an attack windup; light hits don't interrupt a landed swing.
            if (state != State.Attack || info.IsCrit || info.Knockback > 5f || !attackLanded)
                Enter(State.HitReact);
        }

        void OnDied()
        {
            Enter(State.Dead);
            if (agent.isOnNavMesh) agent.isStopped = true;
            agent.enabled = false;
            foreach (var c in GetComponentsInChildren<Collider>()) c.enabled = false;
            Flash(new Color(0.15f, 0.1f, 0.05f));
            transform.rotation = Quaternion.Euler(-90f, transform.eulerAngles.y, 0f);
            transform.position += Vector3.up * -0.5f;
            if (UnityEngine.Random.value < potionDropChance)
            {
                var p = FindFirstObjectByType<PlayerController>();
                if (p) p.AddPotion();
                DamageNumbers.Spawn(transform.position + Vector3.up * 2.5f, 1, false, new Color(0.9f, 0.2f, 0.3f), "Potion +");
            }
            OnDeath?.Invoke(this);
        }
    }
}
