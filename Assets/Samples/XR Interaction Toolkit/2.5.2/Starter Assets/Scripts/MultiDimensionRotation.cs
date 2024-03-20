using UnityEngine;

public class MultiDimensionRotation : MonoBehaviour
{
    public Transform centerObject;
    public float rotationSpeedX;
    public float rotationSpeedY;
    public float rotationSpeedZ;

    private void Update()
    {
        transform.RotateAround(centerObject.position, Vector3.right, rotationSpeedX * Time.deltaTime);
        transform.RotateAround(centerObject.position, Vector3.up, rotationSpeedY * Time.deltaTime);
        transform.RotateAround(centerObject.position, Vector3.forward, rotationSpeedZ * Time.deltaTime);
    }
}