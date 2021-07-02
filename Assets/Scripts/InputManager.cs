using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager _instance;

    public static bool GetInput()
    {
        return Input.GetButton(_instance._inputAxisName);
    }

    public static bool GetInputUp()
    {
        return Input.GetButtonUp(_instance._inputAxisName);
    }

    public static bool GetInputDown()
    {
        return Input.GetButtonDown(_instance._inputAxisName);
    }

    [SerializeField] string _inputAxisName = "Jump";

    private void Awake()
    {
        _instance = this;
    }
}
