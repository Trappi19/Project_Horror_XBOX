using UnityEngine;
using UnityEngine.InputSystem;

public class GamepadDebug : MonoBehaviour
{
    void Update()
    {
        if (Gamepad.current == null) return;

        if (Gamepad.current.dpad.up.wasPressedThisFrame)
            Debug.Log("DPAD UP");
        if (Gamepad.current.buttonSouth.wasPressedThisFrame)
            Debug.Log("BUTTON A");
    }
}
