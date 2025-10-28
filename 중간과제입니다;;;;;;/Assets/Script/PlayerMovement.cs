using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed = 5f;
    public float jumpForce = 6f;
    public Transform cameraTransform;

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // 이동 입력
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 camForward = cameraTransform.forward;
        camForward.y = 0;
        camForward.Normalize();
        Vector3 camRight = cameraTransform.right;
        camRight.y = 0;
        camRight.Normalize();

        Vector3 moveDir = camForward * v + camRight * h;
        Vector3 velocity = moveDir * moveSpeed;
        Vector3 rbVel = rb.velocity;
        rb.velocity = new Vector3(velocity.x, rbVel.y, velocity.z);

        // 점프
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = false;
    }
    // Start is called before the first frame update
   
}
