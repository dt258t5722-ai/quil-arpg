using System.Collections.Generic;
using Unity.AI.Navigation;
using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

namespace Quil
{
    /// <summary>
    /// Builds the Hollowmere greybox test level from primitives: ground, burning cottages, the mill,
    /// Quil (blue capsule with a hatchet), goblins (small green capsules), camera, lights, HUD, spawner.
    /// Used both by the runtime bootstrap and by the editor menu "Quil > Build Test Scene".
    /// </summary>
    public static class HollowmereBuilder
    {
        public static readonly Color QuilColor = new Color(0.25f, 0.4f, 0.75f);
        public static readonly Color GoblinColor = new Color(0.35f, 0.55f, 0.2f);
        static readonly Dictionary<Color, Material> cache = new Dictionary<Color, Material>();

        /// <summary>Called for every material created, so the editor can save them as assets.</summary>
        public static System.Action<Material> MaterialCreated;

        public static Material Mat(Color c, bool emissive = false)
        {
            if (!emissive && cache.TryGetValue(c, out var m) && m != null) return m;
            bool urp = GraphicsSettings.currentRenderPipeline != null;
            var shader = Shader.Find(urp ? "Universal Render Pipeline/Lit" : "Standard");
            if (shader == null) shader = Shader.Find("Standard");
            m = new Material(shader) { color = c, name = "Quil_" + ColorUtility.ToHtmlStringRGB(c) + (emissive ? "_E" : "") };
            if (emissive)
            {
                m.EnableKeyword("_EMISSION");
                m.SetColor("_EmissionColor", c * 3f);
            }
            else cache[c] = m;
            MaterialCreated?.Invoke(m);
            return m;
        }

        static GameObject Prim(PrimitiveType t, string name, Transform parent, Vector3 pos, Vector3 scale, Color c, Quaternion? rot = null)
        {
            var go = GameObject.CreatePrimitive(t);
            go.name = name;
            go.transform.SetParent(parent, false);
            go.transform.localPosition = pos;
            go.transform.localScale = scale;
            go.transform.localRotation = rot ?? Quaternion.identity;
            go.GetComponent<Renderer>().sharedMaterial = Mat(c);
            return go;
        }

        /// <summary>Builds the whole level. bakeNavMesh = true builds the NavMesh immediately.</summary>
        public static GameObject BuildAll(bool bakeNavMesh = true)
        {
            var root = new GameObject("Hollowmere");
            var env = BuildEnvironment(root.transform);
            var surface = env.AddComponent<NavMeshSurface>();
            surface.collectObjects = CollectObjects.Children;
            surface.useGeometry = NavMeshCollectGeometry.PhysicsColliders;
            if (bakeNavMesh) surface.BuildNavMesh();

            BuildLighting(root.transform);
            var player = CreatePlayer(new Vector3(0f, 0.1f, -4f));
            player.transform.SetParent(root.transform, true);
            BuildCamera(root.transform, player.transform);

            var systems = new GameObject("Systems");
            systems.transform.SetParent(root.transform, false);
            var spawner = new GameObject("GoblinSpawner").AddComponent<EnemySpawner>();
            spawner.transform.SetParent(systems.transform, false);
            var points = new List<Transform>();
            Vector3[] sp = { new Vector3(-28, 0, 22), new Vector3(28, 0, 24), new Vector3(30, 0, -26), new Vector3(-30, 0, -24), new Vector3(0, 0, 32) };
            for (int i = 0; i < sp.Length; i++)
            {
                var p = new GameObject("SpawnPoint_" + i).transform;
                p.SetParent(spawner.transform, false);
                p.position = sp[i];
                points.Add(p);
            }
            spawner.spawnPoints = points.ToArray();
            new GameObject("HUD").AddComponent<QuilHUD>().transform.SetParent(systems.transform, false);
            return root;
        }

        static GameObject BuildEnvironment(Transform root)
        {
            var env = new GameObject("Environment");
            env.transform.SetParent(root, false);
            var t = env.transform;

            Prim(PrimitiveType.Plane, "Ground", t, Vector3.zero, new Vector3(9f, 1f, 9f), new Color(0.22f, 0.2f, 0.14f));
            // Muddy village road
            Prim(PrimitiveType.Cube, "Road", t, new Vector3(0, -0.04f, 0), new Vector3(6f, 0.1f, 80f), new Color(0.3f, 0.24f, 0.17f));
            Prim(PrimitiveType.Cube, "CrossRoad", t, new Vector3(0, -0.03f, 6), new Vector3(70f, 0.1f, 5f), new Color(0.3f, 0.24f, 0.17f));

            // Cottages along the road: (position, size, yaw, burning)
            var houses = new (Vector3 p, Vector3 s, float yaw, bool fire)[]
            {
                (new Vector3(-9, 0, -10), new Vector3(6, 3.2f, 5), 5, true),
                (new Vector3(9, 0, -12), new Vector3(5, 3, 6), -8, false),
                (new Vector3(-10, 0, 16), new Vector3(7, 3.5f, 5), 0, true),
                (new Vector3(11, 0, 17), new Vector3(6, 3, 5), 12, true),
                (new Vector3(-20, 0, 2), new Vector3(5, 3, 5), 30, false),
                (new Vector3(21, 0, -1), new Vector3(6, 3.2f, 4.5f), -20, true),
                (new Vector3(-6, 0, 28), new Vector3(5, 3, 5), 10, false),
            };
            int i = 0;
            foreach (var h in houses) BuildCottage(t, "Cottage_" + i++, h.p, h.s, h.yaw, h.fire);

            // The Ashby farmhouse (south, where Tomas fell) and the mill (north-east)
            BuildCottage(t, "AshbyFarmhouse", new Vector3(0, 0, -26), new Vector3(9, 4, 6), 0, true);
            var mill = Prim(PrimitiveType.Cylinder, "Mill", t, new Vector3(24, 3.5f, 24), new Vector3(5, 3.5f, 5), new Color(0.45f, 0.42f, 0.38f));
            Prim(PrimitiveType.Cube, "MillSail_A", mill.transform, new Vector3(0, 0.6f, -0.55f), new Vector3(0.15f, 2.2f, 0.05f), new Color(0.4f, 0.3f, 0.2f), Quaternion.Euler(0, 0, 35));
            Prim(PrimitiveType.Cube, "MillSail_B", mill.transform, new Vector3(0, 0.6f, -0.55f), new Vector3(0.15f, 2.2f, 0.05f), new Color(0.4f, 0.3f, 0.2f), Quaternion.Euler(0, 0, -55));

            // Well in the square, fences, barrels
            Prim(PrimitiveType.Cylinder, "Well", t, new Vector3(5, 0.5f, 6), new Vector3(2f, 0.5f, 2f), new Color(0.4f, 0.4f, 0.42f));
            var rng = new System.Random(7);
            for (int f = 0; f < 14; f++)
            {
                float x = -34 + f * 5;
                Prim(PrimitiveType.Cube, "Fence_" + f, t, new Vector3(x, 0.5f, -36), new Vector3(4.5f, 1f, 0.2f), new Color(0.35f, 0.25f, 0.15f));
            }
            for (int b = 0; b < 10; b++)
            {
                var p = new Vector3((float)rng.NextDouble() * 50 - 25, 0.6f, (float)rng.NextDouble() * 50 - 25);
                if (Mathf.Abs(p.x) < 4f) p.x += 6f;
                Prim(PrimitiveType.Cylinder, "Barrel_" + b, t, p, new Vector3(0.9f, 0.6f, 0.9f), new Color(0.38f, 0.26f, 0.14f));
            }
            // Boundary walls so nobody walks off the world
            Color wall = new Color(0.18f, 0.16f, 0.12f);
            Prim(PrimitiveType.Cube, "Bound_N", t, new Vector3(0, 1.5f, 44), new Vector3(90, 3, 1), wall);
            Prim(PrimitiveType.Cube, "Bound_S", t, new Vector3(0, 1.5f, -44), new Vector3(90, 3, 1), wall);
            Prim(PrimitiveType.Cube, "Bound_E", t, new Vector3(44, 1.5f, 0), new Vector3(1, 3, 90), wall);
            Prim(PrimitiveType.Cube, "Bound_W", t, new Vector3(-44, 1.5f, 0), new Vector3(1, 3, 90), wall);
            return env;
        }

        static void BuildCottage(Transform parent, string name, Vector3 pos, Vector3 size, float yaw, bool burning)
        {
            var house = new GameObject(name).transform;
            house.SetParent(parent, false);
            house.localPosition = pos;
            house.localRotation = Quaternion.Euler(0, yaw, 0);
            Color walls = burning ? new Color(0.2f, 0.15f, 0.12f) : new Color(0.55f, 0.48f, 0.38f);
            Color roof = burning ? new Color(0.12f, 0.08f, 0.06f) : new Color(0.45f, 0.35f, 0.18f);
            Prim(PrimitiveType.Cube, "Walls", house, new Vector3(0, size.y / 2f, 0), size, walls);
            // Thatched roof: a rotated cube sitting on the walls
            Prim(PrimitiveType.Cube, "Roof", house, new Vector3(0, size.y + size.x * 0.18f, 0),
                new Vector3(size.x * 0.75f, size.x * 0.75f, size.z * 1.1f), roof, Quaternion.Euler(0, 0, 45));
            if (burning)
            {
                var fire = new GameObject("Fire");
                fire.transform.SetParent(house, false);
                fire.transform.localPosition = new Vector3(0, size.y + 1.5f, 0);
                var light = fire.AddComponent<Light>();
                light.type = LightType.Point;
                light.color = new Color(1f, 0.5f, 0.15f);
                light.range = 14f;
                light.intensity = 3f;
                fire.AddComponent<FireFlicker>();
                // Glowing embers
                for (int e = 0; e < 3; e++)
                {
                    var ember = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    ember.name = "Ember_" + e;
                    Object.DestroyImmediate(ember.GetComponent<Collider>());
                    ember.transform.SetParent(fire.transform, false);
                    ember.transform.localPosition = new Vector3((e - 1) * size.x * 0.25f, -0.6f + e * 0.2f, 0);
                    ember.transform.localScale = Vector3.one * (0.8f + e * 0.2f);
                    ember.GetComponent<Renderer>().sharedMaterial = Mat(new Color(1f, 0.35f, 0.05f), true);
                }
            }
        }

        static void BuildLighting(Transform root)
        {
            var sun = new GameObject("Dusk Light").AddComponent<Light>();
            sun.transform.SetParent(root, false);
            sun.type = LightType.Directional;
            sun.color = new Color(0.85f, 0.55f, 0.4f);
            sun.intensity = 0.6f;
            sun.shadows = LightShadows.Soft;
            sun.transform.rotation = Quaternion.Euler(35f, -30f, 0f);
            RenderSettings.ambientMode = AmbientMode.Flat;
            RenderSettings.ambientLight = new Color(0.18f, 0.12f, 0.12f);
            RenderSettings.fog = true;
            RenderSettings.fogColor = new Color(0.2f, 0.1f, 0.06f);
            RenderSettings.fogMode = FogMode.Linear;
            RenderSettings.fogStartDistance = 30f;
            RenderSettings.fogEndDistance = 80f;
        }

        static void BuildCamera(Transform root, Transform target)
        {
            var cam = Camera.main;
            if (cam == null)
            {
                var camGo = new GameObject("Main Camera") { tag = "MainCamera" };
                cam = camGo.AddComponent<Camera>();
                camGo.AddComponent<AudioListener>();
            }
            cam.transform.SetParent(root, true);
            cam.clearFlags = CameraClearFlags.SolidColor;
            cam.backgroundColor = new Color(0.1f, 0.05f, 0.04f);
            if (cam.GetComponent<CinemachineBrain>() == null) cam.gameObject.AddComponent<CinemachineBrain>();

            // Diablo-style isometric angle: pitch 50, yaw 45 (matches PlayerController.cameraYaw)
            var rot = Quaternion.Euler(50f, 45f, 0f);
            var vcamGo = new GameObject("CM Isometric Follow");
            vcamGo.transform.SetParent(root, false);
            vcamGo.transform.rotation = rot;
            var vcam = vcamGo.AddComponent<CinemachineCamera>();
            vcam.Follow = target;
            var lens = vcam.Lens;
            lens.FieldOfView = 35f;
            lens.NearClipPlane = 0.3f;
            lens.FarClipPlane = 200f;
            vcam.Lens = lens;
            var follow = vcamGo.AddComponent<CinemachineFollow>();
            follow.FollowOffset = rot * new Vector3(0f, 0f, -26f);
            var tracker = follow.TrackerSettings;
            tracker.BindingMode = Unity.Cinemachine.TargetTracking.BindingMode.WorldSpace;
            tracker.PositionDamping = new Vector3(0.6f, 0.6f, 0.6f);
            follow.TrackerSettings = tracker;
            vcamGo.transform.position = target.position + follow.FollowOffset;
        }

        public static GameObject CreatePlayer(Vector3 pos)
        {
            var go = new GameObject("Quil");
            go.tag = "Player";
            go.transform.position = pos;
            var cc = go.AddComponent<CharacterController>();
            cc.height = 2f; cc.radius = 0.45f; cc.center = new Vector3(0, 1f, 0);
            var h = go.AddComponent<Health>();
            h.maxHealth = 120f;
            h.damageColor = new Color(1f, 0.3f, 0.25f);

            var visual = new GameObject("Visual").transform;
            visual.SetParent(go.transform, false);
            var body = Prim(PrimitiveType.Capsule, "Body", visual, new Vector3(0, 1f, 0), Vector3.one, QuilColor);
            Object.DestroyImmediate(body.GetComponent<Collider>());
            var head = Prim(PrimitiveType.Sphere, "Hair", visual, new Vector3(0, 1.85f, -0.05f), new Vector3(0.55f, 0.35f, 0.55f), new Color(0.35f, 0.2f, 0.1f));
            Object.DestroyImmediate(head.GetComponent<Collider>());
            var nose = Prim(PrimitiveType.Cube, "FacingMarker", visual, new Vector3(0, 1.5f, 0.45f), new Vector3(0.2f, 0.1f, 0.2f), new Color(0.9f, 0.75f, 0.6f));
            Object.DestroyImmediate(nose.GetComponent<Collider>());

            // Tomas's hatchet
            var pivot = new GameObject("HatchetPivot").transform;
            pivot.SetParent(visual, false);
            pivot.localPosition = new Vector3(0.5f, 1.2f, 0.1f);
            var handle = Prim(PrimitiveType.Cube, "Handle", pivot, new Vector3(0, 0, 0.5f), new Vector3(0.08f, 0.08f, 1f), new Color(0.4f, 0.28f, 0.15f));
            Object.DestroyImmediate(handle.GetComponent<Collider>());
            var blade = Prim(PrimitiveType.Cube, "Blade", pivot, new Vector3(0, 0.12f, 0.95f), new Vector3(0.05f, 0.35f, 0.25f), new Color(0.7f, 0.72f, 0.75f));
            Object.DestroyImmediate(blade.GetComponent<Collider>());

            go.AddComponent<PlayerController>();
            return go;
        }

        public static GoblinAI CreateGoblin(Vector3 pos, Quaternion rot)
        {
            var go = new GameObject("Goblin Cutter");
            go.transform.SetPositionAndRotation(pos, rot);
            var col = go.AddComponent<CapsuleCollider>();
            col.height = 1.4f; col.radius = 0.4f; col.center = new Vector3(0, 0.7f, 0);
            var rb = go.AddComponent<Rigidbody>();
            rb.isKinematic = true;
            var h = go.AddComponent<Health>();
            h.maxHealth = 45f;

            var body = Prim(PrimitiveType.Capsule, "Body", go.transform, new Vector3(0, 0.7f, 0), new Vector3(0.8f, 0.7f, 0.8f), GoblinColor);
            Object.DestroyImmediate(body.GetComponent<Collider>());
            // Give each goblin its own material instance so hit flashes don't affect the others.
            body.GetComponent<Renderer>().material = new Material(body.GetComponent<Renderer>().sharedMaterial);
            Color dark = new Color(0.2f, 0.3f, 0.1f);
            var earL = Prim(PrimitiveType.Cube, "Ear_L", go.transform, new Vector3(-0.38f, 1.25f, 0), new Vector3(0.4f, 0.08f, 0.12f), dark, Quaternion.Euler(0, 0, 20));
            var earR = Prim(PrimitiveType.Cube, "Ear_R", go.transform, new Vector3(0.38f, 1.25f, 0), new Vector3(0.4f, 0.08f, 0.12f), dark, Quaternion.Euler(0, 0, -20));
            var eyes = Prim(PrimitiveType.Cube, "Eyes", go.transform, new Vector3(0, 1.15f, 0.3f), new Vector3(0.35f, 0.06f, 0.06f), new Color(1f, 0.85f, 0.1f));
            var blade = Prim(PrimitiveType.Cube, "RustyCleaver", go.transform, new Vector3(0.45f, 0.8f, 0.4f), new Vector3(0.06f, 0.15f, 0.6f), new Color(0.45f, 0.3f, 0.25f));
            foreach (var g in new[] { earL, earR, eyes, blade }) Object.DestroyImmediate(g.GetComponent<Collider>());

            var agent = go.AddComponent<NavMeshAgent>();
            agent.speed = Random.Range(3.6f, 4.6f);
            agent.angularSpeed = 540f;
            agent.acceleration = 20f;
            agent.radius = 0.4f;
            agent.height = 1.4f;
            agent.stoppingDistance = 1.3f;
            if (NavMesh.SamplePosition(pos, out var hit, 3f, NavMesh.AllAreas)) agent.Warp(hit.position);
            return go.AddComponent<GoblinAI>();
        }
    }

    /// <summary>Flickering firelight on burning cottages.</summary>
    public class FireFlicker : MonoBehaviour
    {
        Light l; float baseI; float seed;
        void Awake() { l = GetComponent<Light>(); baseI = l ? l.intensity : 1f; seed = Random.value * 100f; }
        void Update() { if (l) l.intensity = baseI * (0.75f + 0.5f * Mathf.PerlinNoise(seed, Time.time * 6f)); }
    }
}
