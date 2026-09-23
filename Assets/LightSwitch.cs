using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public InputActionReference action;
    private Light pointLight;

    void Start()
    {
        pointLight = GetComponent<Light>();
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            pointLight.color = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f);
        };
    }
}