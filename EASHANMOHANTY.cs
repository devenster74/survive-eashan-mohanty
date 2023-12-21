using UnityEngine;

public class EASHANMOHANTY : MonoBehaviour
{
    public Transform playerTransform;
    public float speed = 1.0f;

    void Update()
    {
        Vector3 direction = playerTransform.position - transform.position;
        direction.Normalize();

        transform.position += direction * speed * Time.deltaTime;

        transform.LookAt(playerTransform);
    }
}
