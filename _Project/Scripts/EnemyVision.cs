using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    public Transform player;
    public float visionRange = 6f;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector2 direction = (player.position - transform.position).normalized;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, visionRange);
        Debug.DrawRay(transform.position, direction * visionRange, Color.yellow);

        if (hit.collider != null && hit.collider.CompareTag("Player"))
        {
            spriteRenderer.color = Color.red;    // I can see you!
        }
        else
        {
            spriteRenderer.color = Color.white;
        }
    }

}
