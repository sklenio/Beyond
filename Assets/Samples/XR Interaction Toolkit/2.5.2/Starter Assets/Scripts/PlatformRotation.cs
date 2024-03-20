using UnityEngine;

public class PlatformRotation : MonoBehaviour
{
    public float rotationSpeed = 3f; // Adjust the speed as per your requirement

    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}