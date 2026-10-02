using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private ScriptableTest[] enemyData;
	private ScriptableTest data;
	private int currentHealth;

    void Start()
    {
        data = GetRandomEnemyData();
        currentHealth = data.maxHealth;
        GetComponent<SpriteRenderer>().color = data.color;
    }

    void Update()
    {
        transform.Translate(Vector2.right * data.speed * Time.deltaTime);
    }

    public void TakeDamage(int amount) 
    { 
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public ScriptableTest GetRandomEnemyData() 
    {
		int index = Random.Range(0, enemyData.Length);
        return enemyData[index];
	}
}
