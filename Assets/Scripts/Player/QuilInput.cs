using UnityEngine;
using UnityEngine.InputSystem;

namespace Quil
{
    /// <summary>
    /// Input actions built in code (no .inputactions asset to wire up).
    /// Xbox controller first, keyboard + mouse fallback.
    /// </summary>
    public class QuilInput : System.IDisposable
    {
        public readonly InputAction Move, Aim, Light, Heavy, Dodge, Potion;
        public bool UsingGamepad { get; private set; }

        public QuilInput()
        {
            Move = new InputAction("Move", InputActionType.Value);
            Move.AddBinding("<Gamepad>/leftStick");
            Move.AddCompositeBinding("2DVector")
                .With("Up", "<Keyboard>/w").With("Down", "<Keyboard>/s")
                .With("Left", "<Keyboard>/a").With("Right", "<Keyboard>/d");
            Move.AddCompositeBinding("2DVector")
                .With("Up", "<Keyboard>/upArrow").With("Down", "<Keyboard>/downArrow")
                .With("Left", "<Keyboard>/leftArrow").With("Right", "<Keyboard>/rightArrow");

            Aim = new InputAction("Aim", InputActionType.Value, "<Gamepad>/rightStick");

            Light = new InputAction("LightAttack", InputActionType.Button);
            Light.AddBinding("<Gamepad>/buttonSouth");   // A
            Light.AddBinding("<Gamepad>/rightTrigger");  // RT
            Light.AddBinding("<Mouse>/leftButton");

            Heavy = new InputAction("HeavyAttack", InputActionType.Button);
            Heavy.AddBinding("<Gamepad>/buttonWest");    // X
            Heavy.AddBinding("<Mouse>/rightButton");

            Dodge = new InputAction("Dodge", InputActionType.Button);
            Dodge.AddBinding("<Gamepad>/buttonEast");    // B
            Dodge.AddBinding("<Keyboard>/space");

            Potion = new InputAction("Potion", InputActionType.Button);
            Potion.AddBinding("<Gamepad>/buttonNorth");  // Y
            Potion.AddBinding("<Keyboard>/q");
            Potion.AddBinding("<Keyboard>/1");

            foreach (var a in All) a.Enable();
        }

        InputAction[] All => new[] { Move, Aim, Light, Heavy, Dodge, Potion };

        /// <summary>Tracks whether the last meaningful input came from a gamepad (for aim mode).</summary>
        public void UpdateDevice()
        {
            var pad = Gamepad.current;
            if (pad != null && (pad.leftStick.ReadValue().sqrMagnitude > 0.04f || pad.rightStick.ReadValue().sqrMagnitude > 0.04f
                || pad.buttonSouth.isPressed || pad.rightTrigger.isPressed))
                UsingGamepad = true;
            var mouse = Mouse.current;
            if (mouse != null && (mouse.delta.ReadValue().sqrMagnitude > 4f || mouse.leftButton.isPressed))
                UsingGamepad = false;
        }

        public void Rumble(float low, float high, float duration, MonoBehaviour host)
        {
            var pad = Gamepad.current;
            if (pad == null || !UsingGamepad || host == null) return;
            pad.SetMotorSpeeds(low, high);
            host.StartCoroutine(StopRumble(pad, duration));
        }

        static System.Collections.IEnumerator StopRumble(Gamepad pad, float d)
        {
            yield return new WaitForSecondsRealtime(d);
            if (pad != null) pad.SetMotorSpeeds(0f, 0f);
        }

        public void Dispose()
        {
            foreach (var a in All) { a.Disable(); a.Dispose(); }
            Gamepad.current?.SetMotorSpeeds(0f, 0f);
        }
    }
}
