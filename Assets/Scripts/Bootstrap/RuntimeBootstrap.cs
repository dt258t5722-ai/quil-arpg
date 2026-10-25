using UnityEngine;

namespace Quil
{
    /// <summary>
    /// Press Play in ANY scene (even an empty one): if there's no Quil in the scene, Hollowmere is built
    /// on the fly, including a runtime NavMesh bake. The saved Hollowmere.unity already contains everything.
    /// </summary>
    public static class RuntimeBootstrap
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        static void Init()
        {
            if (Object.FindFirstObjectByType<PlayerController>() != null) return;
            Debug.Log("[Quil] No player found in scene - building Hollowmere at runtime.");
            HollowmereBuilder.BuildAll(bakeNavMesh: true);
        }
    }
}
