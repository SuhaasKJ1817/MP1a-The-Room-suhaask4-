using UnityEngine;

public class ShooterProjectile : MonoBehaviour
{
    public Vector3 velocity;
    public Transform attractor;
    public float gravity = 0.2f;

    void Update()
    {
        Vector3 attractorPos = attractor != null ? attractor.position : Vector3.zero;
        Vector3 offset = transform.position - attractorPos;
        float distance = offset.magnitude;

        float ax = -gravity * offset.x / Mathf.Pow(distance, 3);
        float ay = -gravity * offset.y / Mathf.Pow(distance, 3);
        float az = -gravity * offset.z / Mathf.Pow(distance, 3);

        velocity.x += ax * Time.deltaTime;
        velocity.y += ay * Time.deltaTime;
        velocity.z += az * Time.deltaTime;

        transform.position += velocity * Time.deltaTime;
    }
}