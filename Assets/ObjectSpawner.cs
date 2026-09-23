using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public GameObject particlePrefab;
    public AudioClip spawnSound;
    public Transform spawnPoint;
    public InputActionReference action;

    public Transform attractor;
    public float gravity = 0.2f;

    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            Vector3 spawnPos = spawnPoint.position;

            GameObject spawned = Instantiate(objectPrefab, spawnPos, Quaternion.identity);

            ShooterProjectile proj = spawned.GetComponent<ShooterProjectile>();
            if (proj != null && attractor != null)
            {
                proj.attractor = attractor;
                proj.gravity = gravity;

                Vector3 toAttractor = attractor.position - spawnPos;
                float distance = toAttractor.magnitude;
                Vector3 radialDir = toAttractor.normalized;
                Vector3 rawDir = spawnPoint.forward;

                Vector3 tangentDir = (rawDir - Vector3.Project(rawDir, radialDir)).normalized;
                float stableSpeed = Mathf.Sqrt(gravity / distance);

                proj.velocity = tangentDir * stableSpeed;
            }
            if (particlePrefab != null)
            {
                GameObject fx = Instantiate(particlePrefab, spawnPos, Quaternion.identity);
                Destroy(fx, 3f);
            }

            if (spawnSound != null)
            {
                GameObject audioObj = new GameObject("SpawnSound");
                audioObj.transform.position = spawnPos;
                AudioSource src = audioObj.AddComponent<AudioSource>();
                src.clip = spawnSound;
                src.spatialBlend = 1f;
                src.Play();
                Destroy(audioObj, spawnSound.length);
            }
        };
    }
}