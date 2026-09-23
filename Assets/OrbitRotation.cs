using UnityEngine;

public class OrbitRotation : MonoBehaviour
{
    public float rotationSpeed = 30f; // degrees per second

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}