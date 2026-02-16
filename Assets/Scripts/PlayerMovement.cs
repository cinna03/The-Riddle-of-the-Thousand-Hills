using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 200f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // prevent tipping over
    }

    void Update()
    {
        // Movement
        float move = Input.GetAxis("Vertical"); // W/S or Up/Down
        float turn = Input.GetAxis("Horizontal"); // A/D or Left/Right

        Vector3 moveVector = transform.forward * move * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + moveVector);

        // Rotation
        Vector3 turnVector = Vector3.up * turn * turnSpeed * Time.deltaTime;
        rb.MoveRotation(rb.rotation * Quaternion.Euler(turnVector));
    }
}
