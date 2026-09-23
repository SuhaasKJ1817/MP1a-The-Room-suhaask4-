using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerTeleport : MonoBehaviour
{
    public Transform externalPoint;
    public InputActionReference action;

    private Vector3 roomPosition;
    private bool isExternal = false;

    void Start()
    {
        roomPosition = transform.position; 
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            isExternal = !isExternal;
            transform.position = isExternal ? externalPoint.position : roomPosition;
        };
    }
}