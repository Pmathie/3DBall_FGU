using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 10f;           // Hastigheden som bolden bevæger sig med
    public float jumpForce = 5f;        // Kraften som bolden hopper med
    public Transform cameraTransform;   // Vores kamera, der renderer scenen

    private Rigidbody rb;               // Vores RigidBody komponent, der styrer fysikken
    private Vector3 moveDirection;      // Vores bevægelsesretning
        
    public bool isGrounded = true;      // Om bolden er på jorden
    public bool wantsToJump = false;    // Om spilleren ønsker at hoppe

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Vi henter vores RigidBody komponent og gemmer den i rb variablen
        cameraTransform = Camera.main.transform; // Vi henter hovedkameraets transform komponent og gemmer den i cameraTransform variablen

    }

    void Update()
    {
        // Vi henter input fra tastaturet eller controlleren og gemmer det i h og v variablerne
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 2) Use camera direction (ignore up/down tilt)
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;
        forward.y = 0f;
        right.y = 0f;

        // 3) Combine into one movement vector
        moveDirection = (forward * v + right * h).normalized;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            wantsToJump = true;
        }


    }

    void FixedUpdate()
    {
        // 4) Apply movement using physics
        rb.AddForce(moveDirection * speed);
        
        if (wantsToJump && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            wantsToJump = false;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.layer == 3)
        {
            isGrounded = true;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        
        if (collision.gameObject.layer == 3)
        {
            isGrounded = false;
        }
    }
}