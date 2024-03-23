using UnityEngine;

public class TeleportToRespawn : MonoBehaviour
{
    public Transform respawnPoint;
    public float teleportDistanceThreshold = 20f;
    public GameObject visualEffect; // The visual effect to be instantiated when teleporting
    private Rigidbody rb; // Reference to the Rigidbody component

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Calculate the distance between the object and the respawn point
        float distanceToRespawn = Vector3.Distance(transform.position, respawnPoint.position);

        // Check if the object is beyond the teleport distance threshold
        if (distanceToRespawn > teleportDistanceThreshold)
        {
            // Teleport the object to the respawn point
            transform.position = respawnPoint.position;

            // Stop the object's movement
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            // Instantiate the visual effect at the respawn point
            Instantiate(visualEffect, respawnPoint.position, Quaternion.identity);
        }
    }
}