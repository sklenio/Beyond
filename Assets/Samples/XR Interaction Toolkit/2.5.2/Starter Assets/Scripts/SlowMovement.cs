using UnityEngine;

public class SlowMovement : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public float speed = 1f;

    private float t = 0f;

    private void Update()
    {
        t += Time.deltaTime * speed;
        transform.position = Vector3.Lerp(startPoint.position, endPoint.position, t);
    }
}