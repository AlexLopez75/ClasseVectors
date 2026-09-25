using UnityEngine;

public class MoveByForce : MonoBehaviour
{
    public Rigidbody2D rb;
    public int force = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector2(force, 0f));

    }
}
