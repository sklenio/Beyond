using UnityEngine;

public class DisableOnTrigger : MonoBehaviour
{
    public GameObject platformOne; // Reference to Platform One with the rotation script
    public AudioSource playSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Assuming the player is the one triggering the collider
        {
            playSound.Play();
            Debug.Log("DisableOnTrigger.cs: Audio is playing");
            Debug.Log("DisableOnTrigger.cs: Player has triggered the small platform");

            // Stop the rotation of Platform One
            if (platformOne != null)
            {
                PlatformRotation platformRotation = platformOne.GetComponent<PlatformRotation>();
                if (platformRotation != null)
                {
                    platformRotation.enabled = false;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Assuming the player is the one triggering the collider
        {
           Debug.Log("DisableOnTrigger.cs: Player has left the small platform");
            // Resume the rotation of Platform One
            if (platformOne != null)
            {
                PlatformRotation platformRotation = platformOne.GetComponent<PlatformRotation>();
                if (platformRotation != null)
                {
                    platformRotation.enabled = true;
                }
            }
        }
    }
}