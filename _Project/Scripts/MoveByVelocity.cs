using UnityEngine;

public class MoveByVelocity : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector2(speed, 0f);
    }
}
