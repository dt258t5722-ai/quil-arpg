using System.IO;
using Unity.AI.Navigation;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

namespace Quil.EditorTools
{
    /// <summary>Menu: Quil > Build Test Scene. Generates, bakes and saves Assets/Scenes/Hollowmere.unity.</summary>
    public static class QuilSceneBuilder
    {
        const string ScenePath = "Assets/Scenes/Hollowmere.unity";
        const string DataDir = "Assets/Scenes/Hollowmere";
        const string SettingsDir = "Assets/Settings";

        [MenuItem("Quil/Build Test Scene", priority = 0)]
        public static void BuildTestScene()
        {
            if (!EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo()) return;

            EnsureUrp();
            EnsureInputSystemEnabled();

            var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            Directory.CreateDirectory(DataDir + "/Materials");
            AssetDatabase.Refresh();

            int matIndex = 0;
            HollowmereBuilder.MaterialCreated = m =>
            {
                AssetDatabase.CreateAsset(m, $"{DataDir}/Materials/{m.name}_{matIndex++}.mat");
            };
            try
            {
                HollowmereBuilder.BuildAll(bakeNavMesh: true);
            }
            finally
            {
                HollowmereBuilder.MaterialCreated = null;
            }

            // Persist the baked NavMesh as an asset next to the scene.
            var surface = Object.FindFirstObjectByType<NavMeshSurface>();
            if (surface != null && surface.navMeshData != null)
            {
                string navPath = DataDir + "/NavMesh-Environment.asset";
                AssetDatabase.DeleteAsset(navPath);
                AssetDatabase.CreateAsset(surface.navMeshData, navPath);
                EditorUtility.SetDirty(surface);
            }
            else Debug.LogWarning("[Quil] NavMesh bake produced no data - select Hollowmere/Environment and press Bake on its NavMeshSurface.");

            EditorSceneManager.MarkSceneDirty(scene);
            EditorSceneManager.SaveScene(scene, ScenePath);
            AssetDatabase.SaveAssets();
            AddToBuildSettings(ScenePath);
            Debug.Log("[Quil] Built and saved " + ScenePath + ". Press Play!");
        }

        [MenuItem("Quil/Rebake NavMesh", priority = 1)]
        public static void Rebake()
        {
            foreach (var s in Object.FindObjectsByType<NavMeshSurface>(FindObjectsSortMode.None))
            {
                s.BuildNavMesh();
                EditorUtility.SetDirty(s);
            }
            EditorSceneManager.MarkSceneDirty(SceneManager.GetActiveScene());
        }

        /// <summary>Creates a URP asset + renderer and assigns them, if the project has no pipeline yet.</summary>
        static void EnsureUrp()
        {
            if (GraphicsSettings.defaultRenderPipeline != null) return;
            Directory.CreateDirectory(SettingsDir);
            AssetDatabase.Refresh();
            var rendererData = ScriptableObject.CreateInstance<UniversalRendererData>();
            AssetDatabase.CreateAsset(rendererData, SettingsDir + "/Quil_URP_Renderer.asset");
            var urp = UniversalRenderPipelineAsset.Create(rendererData);
            urp.shadowDistance = 60f;
            AssetDatabase.CreateAsset(urp, SettingsDir + "/Quil_URP.asset");
            AssetDatabase.SaveAssets();
            GraphicsSettings.defaultRenderPipeline = urp;
            for (int i = 0; i < QualitySettings.names.Length; i++)
            {
                QualitySettings.SetQualityLevel(i, false);
                QualitySettings.renderPipeline = urp;
            }
            Debug.Log("[Quil] Created and assigned URP asset at " + SettingsDir);
        }

        /// <summary>Sets Player > Active Input Handling to "Both" so the Input System works.</summary>
        static void EnsureInputSystemEnabled()
        {
            var assets = AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/ProjectSettings.asset");
            if (assets == null || assets.Length == 0) return;
            var so = new SerializedObject(assets[0]);
            var prop = so.FindProperty("activeInputHandler");
            if (prop == null || prop.intValue != 0) return;
            prop.intValue = 2; // 0 = old, 1 = new Input System, 2 = both
            so.ApplyModifiedProperties();
            EditorUtility.DisplayDialog("Quil",
                "Active Input Handling was switched to 'Both' so the Xbox controller works.\n\n" +
                "Unity needs a restart for this to take effect. Save, close and reopen the project, then run Quil > Build Test Scene again.",
                "OK");
        }

        static void AddToBuildSettings(string path)
        {
            var list = new System.Collections.Generic.List<EditorBuildSettingsScene>(EditorBuildSettings.scenes);
            if (list.Exists(s => s.path == path)) return;
            list.Insert(0, new EditorBuildSettingsScene(path, true));
            EditorBuildSettings.scenes = list.ToArray();
        }
    }
}
