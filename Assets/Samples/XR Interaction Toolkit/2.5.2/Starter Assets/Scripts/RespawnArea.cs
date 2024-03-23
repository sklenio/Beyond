using UnityEngine;

public class RespawnObject : MonoBehaviour
{
    public Transform respawnPoint; // Assign the respawn point in the Inspector
    public float returnSpeed = 5f; // Adjust the speed as needed

    private Rigidbody rb;
    private bool isReturning = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Interactable"))
        {
            isReturning = true;
        }
    }

    private void Update()
    {
        if (isReturning)
        {
            Vector3 direction = (respawnPoint.position - transform.position).normalized;
            rb.MovePosition(transform.position + direction * returnSpeed * Time.deltaTime);

            // If the object is close enough to the respawn point, stop returning and reset its velocity
            if (Vector3.Distance(transform.position, respawnPoint.position) < 0.1f)
            {
                isReturning = false;
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
        }
    }
}