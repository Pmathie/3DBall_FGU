using UnityEngine;

public class BallMovement1 : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;
    private Vector3 moveDirection;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;

    }
    void FixedUpdate()
    {
        rb.AddForce(moveDirection * speed);
    }
}
