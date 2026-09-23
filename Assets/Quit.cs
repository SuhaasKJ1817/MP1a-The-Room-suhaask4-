using UnityEngine;
using UnityEngine.InputSystem;

public class Quit : MonoBehaviour
{
    public InputActionReference action;
    void Start()
    {
        Debug.Log("Quit script Start() ran. Action assigned: " + (action != null));
        action.action.Enable();
        Debug.Log("Action enabled: " + action.action.name);
        action.action.performed += (ctx) =>
        {
            Debug.Log("Quit action triggered!");
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        };
    }
}