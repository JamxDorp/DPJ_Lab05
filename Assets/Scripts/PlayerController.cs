using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5;
    [SerializeField] float jumpHeight = 1.5f;
    [SerializeField] LayerMask groundLayers = ~0; 
    [SerializeField] float groundCheckDistance = 0.1f;
    public int points;

    private Rigidbody rb;
    private Collider col;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
        rb.constraints = RigidbodyConstraints.FreezeRotation; 
    }

    private void Update()
    {
        MovePlayer();

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
        }
    }

    private void MovePlayer()
    {
        float xMoveValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float yMoveValue = 0;       
        float zMoveValue = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(xMoveValue, yMoveValue, zMoveValue);
    }

    private void Jump()
    {
        float jumpVelocity = Mathf.Sqrt(jumpHeight * -2f * Physics.gravity.y);
        rb.AddForce(Vector3.up * jumpVelocity, ForceMode.VelocityChange);
    }

    private bool IsGrounded()
    {
        float distance = col.bounds.extents.y + groundCheckDistance;
        return Physics.Raycast(col.bounds.center, Vector3.down, distance, groundLayers, QueryTriggerInteraction.Ignore);
    }
}
