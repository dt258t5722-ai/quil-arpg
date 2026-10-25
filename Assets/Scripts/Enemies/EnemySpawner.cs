using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Quil
{
    /// <summary>Keeps up to maxAlive goblins around the village, spawning in waves.</summary>
    public class EnemySpawner : MonoBehaviour
    {
        public int maxAlive = 8;
        public float spawnInterval = 3f;
        public float spawnRadius = 30f;
        public float minDistanceFromPlayer = 12f;
        public Transform[] spawnPoints;

        public int Kills { get; private set; }
        public int Wave { get; private set; } = 1;

        readonly List<GoblinAI> alive = new List<GoblinAI>();
        float timer;
        Transform player;

        void Start()
        {
            var p = FindFirstObjectByType<PlayerController>();
            if (p) player = p.transform;
            timer = 1f;
        }

        void Update()
        {
            alive.RemoveAll(g => g == null);
            timer -= Time.deltaTime;
            if (timer > 0f || CountLiving() >= maxAlive) return;
            timer = spawnInterval;
            if (TryFindPoint(out Vector3 pos))
            {
                var g = HollowmereBuilder.CreateGoblin(pos, Quaternion.Euler(0f, Random.Range(0f, 360f), 0f));
                if (g == null) return;
                // Goblins grow tougher every 10 kills.
                var h = g.GetComponent<Health>();
                h.maxHealth *= 1f + 0.15f * (Wave - 1); h.current = h.maxHealth;
                g.damage *= 1f + 0.1f * (Wave - 1);
                g.OnDeath += OnGoblinDeath;
                alive.Add(g);
            }
        }

        int CountLiving()
        {
            int n = 0;
            foreach (var g in alive) if (g != null && g.state != GoblinAI.State.Dead) n++;
            return n;
        }

        void OnGoblinDeath(GoblinAI g)
        {
            Kills++;
            Wave = 1 + Kills / 10;
        }

        bool TryFindPoint(out Vector3 result)
        {
            for (int i = 0; i < 12; i++)
            {
                Vector3 candidate;
                if (spawnPoints != null && spawnPoints.Length > 0)
                    candidate = spawnPoints[Random.Range(0, spawnPoints.Length)].position + Random.insideUnitSphere * 2f;
                else
                {
                    var c = Random.insideUnitCircle * spawnRadius;
                    candidate = transform.position + new Vector3(c.x, 0f, c.y);
                }
                if (player && Vector3.Distance(candidate, player.position) < minDistanceFromPlayer) continue;
                if (NavMesh.SamplePosition(candidate, out NavMeshHit hit, 3f, NavMesh.AllAreas))
                {
                    result = hit.position;
                    return true;
                }
            }
            result = Vector3.zero;
            return false;
        }
    }
}
