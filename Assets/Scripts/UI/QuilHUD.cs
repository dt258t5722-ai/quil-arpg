using UnityEngine;
using UnityEngine.InputSystem;

namespace Quil
{
    /// <summary>Simple IMGUI HUD: health, stamina, potions, kills/wave, death screen.</summary>
    public class QuilHUD : MonoBehaviour
    {
        PlayerController player;
        EnemySpawner spawner;
        Texture2D white;
        GUIStyle label, big;
        float shownHealth = 1f;
        float deadTime;
        Vector3 spawnPos;

        void Start()
        {
            player = FindFirstObjectByType<PlayerController>();
            spawner = FindFirstObjectByType<EnemySpawner>();
            if (player) spawnPos = player.transform.position;
            white = Texture2D.whiteTexture;
        }

        void Update()
        {
            if (player == null) return;
            shownHealth = Mathf.MoveTowards(shownHealth, player.Health.Normalized, Time.deltaTime * 0.5f);
            if (player.Health.IsDead)
            {
                deadTime += Time.deltaTime;
                bool rise = (Gamepad.current != null && Gamepad.current.buttonSouth.wasPressedThisFrame)
                    || (Keyboard.current != null && Keyboard.current.enterKey.wasPressedThisFrame);
                if (deadTime > 1.5f && rise) { player.Respawn(spawnPos); deadTime = 0f; shownHealth = 1f; }
            }
        }

        void Bar(Rect r, float fill, float ghost, Color c)
        {
            GUI.color = new Color(0, 0, 0, 0.7f); GUI.DrawTexture(new Rect(r.x - 2, r.y - 2, r.width + 4, r.height + 4), white);
            GUI.color = new Color(1f, 1f, 1f, 0.5f); GUI.DrawTexture(new Rect(r.x, r.y, r.width * ghost, r.height), white);
            GUI.color = c; GUI.DrawTexture(new Rect(r.x, r.y, r.width * Mathf.Clamp01(fill), r.height), white);
            GUI.color = Color.white;
        }

        void OnGUI()
        {
            if (player == null) return;
            float s = Screen.height / 1080f;
            if (label == null)
            {
                label = new GUIStyle(GUI.skin.label) { fontStyle = FontStyle.Bold };
                big = new GUIStyle(GUI.skin.label) { alignment = TextAnchor.MiddleCenter, fontStyle = FontStyle.Bold };
            }
            label.fontSize = Mathf.RoundToInt(24 * s);
            big.fontSize = Mathf.RoundToInt(72 * s);

            float x = 40 * s, w = 420 * s, h = 28 * s, y = Screen.height - 150 * s;
            var hp = player.Health;
            Bar(new Rect(x, y, w, h), hp.Normalized, Mathf.Max(shownHealth, hp.Normalized), new Color(0.75f, 0.1f, 0.1f));
            GUI.Label(new Rect(x + 8 * s, y - 2 * s, w, h + 4 * s), $"HP {Mathf.CeilToInt(hp.current)}/{hp.maxHealth}", label);
            y += h + 12 * s;
            Bar(new Rect(x, y, w, h * 0.7f), player.StaminaNormalized, 0f, new Color(0.9f, 0.75f, 0.2f));
            y += h * 0.7f + 12 * s;
            GUI.Label(new Rect(x, y, w, h * 1.5f), $"Potions: {player.potions}/{player.maxPotions}   (Y / Q)", label);

            if (spawner != null)
                GUI.Label(new Rect(Screen.width - 360 * s, 30 * s, 340 * s, 40 * s), $"Goblins slain: {spawner.Kills}   Wave {spawner.Wave}", label);

            GUI.color = new Color(1, 1, 1, 0.6f);
            label.fontSize = Mathf.RoundToInt(18 * s);
            GUI.Label(new Rect(40 * s, 20 * s, 1200 * s, 30 * s),
                "LS move · RS aim · A/RT hatchet combo · X heavy · B dodge · Y potion     (KB: WASD, mouse aim, LMB, RMB, Space, Q)", label);
            GUI.color = Color.white;

            if (hp.IsDead)
            {
                GUI.color = new Color(0, 0, 0, 0.55f); GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), white);
                GUI.color = new Color(0.8f, 0.1f, 0.1f);
                GUI.Label(new Rect(0, Screen.height * 0.35f, Screen.width, 100 * s), "HOLLOWMERE BURNS", big);
                GUI.color = Color.white;
                label.fontSize = Mathf.RoundToInt(28 * s);
                label.alignment = TextAnchor.MiddleCenter;
                GUI.Label(new Rect(0, Screen.height * 0.35f + 110 * s, Screen.width, 50 * s), "Press A / Enter to rise again", label);
                label.alignment = TextAnchor.UpperLeft;
            }
        }
    }
}
