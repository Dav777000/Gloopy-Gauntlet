using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Move : MonoBehaviour
{
    public float speed = 2.5f; // Velocidad de movimiento del jugador
    public float rotationSpeed = 10f; // Velocidad de rotación del jugador

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // Evita que el objeto rote debido a la física
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Calcula la velocidad del movimiento
        Vector3 velocity = moveDirection * speed;

        // Aplica el movimiento al Rigidbody
        rb.velocity = new Vector3(velocity.x, rb.velocity.y, velocity.z);

        if (moveDirection != Vector3.zero)
        {
            // Calcula la rotación hacia la dirección del movimiento
            Quaternion toRotation = Quaternion.LookRotation(moveDirection, Vector3.up);

            // Aplica la rotación suavizada al Rigidbody
            rb.MoveRotation(Quaternion.Slerp(rb.rotation, toRotation, rotationSpeed * Time.fixedDeltaTime));
        }
    }
}
