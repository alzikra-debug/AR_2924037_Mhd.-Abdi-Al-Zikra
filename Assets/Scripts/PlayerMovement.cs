using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontal = 0f;
        float vertical = 0f;

        // Input 1: Keyboard (untuk Editor/PC)
        horizontal += Input.GetAxis("Horizontal");
        vertical += Input.GetAxis("Vertical");

        // Input 2: Mobile Touch Buttons (untuk Android)
        horizontal += MobileInput.horizontal;
        vertical += MobileInput.vertical;

        // Normalisasi agar kecepatan tetap konsisten
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        Vector3 nextPosition = rb.position + direction * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(nextPosition);
    }
}