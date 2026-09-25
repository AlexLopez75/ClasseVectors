using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 7f;
    private Rigidbody2D rb;
    public float rayLength = 0.6f; 
    public LayerMask groundLayer;

    public bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, rayLength, groundLayer);
        Debug.DrawRay(transform.position, Vector2.down * rayLength, hit.collider != null ? Color.green : Color.red);

        return hit.collider != null;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        float horizontal = Input.GetAxisRaw("Horizontal"); // -1, 0 or 1
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);

        bool grounded = IsGrounded();

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

}
