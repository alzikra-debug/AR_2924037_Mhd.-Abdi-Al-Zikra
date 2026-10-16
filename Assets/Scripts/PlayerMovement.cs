using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 8f; // Speed dinaikkan sedikit karena input tilt lebih halus daripada keyboard
    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Mengganti Input.GetAxis dengan Input.acceleration (Gyroscope/Accelerometer HP)
        float horizontal = Input.acceleration.x;
        float vertical = Input.acceleration.y;

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        Vector3 nextPosition = rb.position + direction * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(nextPosition);
    }
}