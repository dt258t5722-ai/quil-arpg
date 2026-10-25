using System.Collections.Generic;
using UnityEngine;

namespace Quil
{
    /// <summary>Floating damage numbers drawn with IMGUI (no TextMeshPro setup needed).</summary>
    public class DamageNumbers : MonoBehaviour
    {
        class Entry { public Vector3 pos; public string text; public Color color; public float t; public bool crit; public float drift; }

        static DamageNumbers instance;
        readonly List<Entry> entries = new List<Entry>();
        const float Lifetime = 1.0f;
        GUIStyle style;

        public static void Spawn(Vector3 worldPos, float amount, bool crit, Color color, string prefix = "")
        {
            if (instance == null)
            {
                var go = new GameObject("DamageNumbers");
                instance = go.AddComponent<DamageNumbers>();
            }
            instance.entries.Add(new Entry
            {
                pos = worldPos,
                text = prefix + Mathf.RoundToInt(amount) + (crit ? "!" : ""),
                color = crit ? new Color(1f, 0.75f, 0.1f) : color,
                crit = crit,
                drift = Random.Range(-0.4f, 0.4f)
            });
        }

        void Update()
        {
            for (int i = entries.Count - 1; i >= 0; i--)
            {
                entries[i].t += Time.deltaTime;
                if (entries[i].t > Lifetime) entries.RemoveAt(i);
            }
        }

        void OnGUI()
        {
            var cam = Camera.main;
            if (cam == null) return;
            if (style == null)
            {
                style = new GUIStyle(GUI.skin.label) { alignment = TextAnchor.MiddleCenter, fontStyle = FontStyle.Bold };
            }
            foreach (var e in entries)
            {
                float k = e.t / Lifetime;
                Vector3 wp = e.pos + new Vector3(e.drift, k * 1.5f, 0f);
                Vector3 sp = cam.WorldToScreenPoint(wp);
                if (sp.z < 0f) continue;
                float scale = Screen.height / 1080f;
                int size = Mathf.RoundToInt((e.crit ? 44 : 30) * scale * (e.crit ? 1.3f - 0.3f * k : 1f));
                style.fontSize = Mathf.Max(10, size);
                var rect = new Rect(sp.x - 100, Screen.height - sp.y - 30, 200, 60);
                var c = e.color; c.a = 1f - k * k;
                style.normal.textColor = new Color(0, 0, 0, c.a);
                GUI.Label(new Rect(rect.x + 2, rect.y + 2, rect.width, rect.height), e.text, style);
                style.normal.textColor = c;
                GUI.Label(rect, e.text, style);
            }
        }
    }
}
