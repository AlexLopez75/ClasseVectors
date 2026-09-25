using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SmartTurret : MonoBehaviour
{
	public Transform player;
	public GameObject bulletPrefab;
	public float visionRange = 6f;
	private SpriteRenderer spriteRenderer;
	public float bulletSpeed = 10f;
	public float timeBetweenShots = 1f;
	public float shotTimer = 0f;

	void Shoot(Vector2 direction) 
	{
		GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
		Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();

		bulletRb.linearVelocity = direction * bulletSpeed;

		Destroy(bullet, 3f);
	}

	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	void Update()
	{

		Debug.Log(shotTimer);

		Vector2 direction = (player.position - transform.position).normalized;
		RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, visionRange);
		Debug.DrawRay(transform.position, direction * visionRange, Color.yellow);

		if (hit.collider != null && hit.collider.CompareTag("Player"))
		{
			spriteRenderer.color = Color.red;    // I can see you!

			var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
			transform.eulerAngles = new Vector3(0f, 0f, angle);

			shotTimer += Time.deltaTime;
			if (shotTimer > timeBetweenShots) 
			{
				Debug.Log("Shot");
				Shoot(direction);
				shotTimer = 0f;
			}
		}
		else
		{
			spriteRenderer.color = Color.white;
		}
	}
}
