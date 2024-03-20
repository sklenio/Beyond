using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    public float rotationSpeedX;
    public float rotationSpeedY;
    public float rotationSpeedZ;

    private void Update()
    {
        // Rotate the object around the x-axis
        transform.Rotate(Vector3.right * rotationSpeedX * Time.deltaTime);

        // Rotate the object around the y-axis
        transform.Rotate(Vector3.up * rotationSpeedY * Time.deltaTime);

        // Rotate the object around the z-axis
        transform.Rotate(Vector3.forward * rotationSpeedZ * Time.deltaTime);
    }
}