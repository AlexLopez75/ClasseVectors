using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private ObjectPool pool;
    [SerializeField] private float spawnInterval = 1f;

    private float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            timer = 0f;
            Vector3 position = transform.position;
            GameObject newObject = pool.GetObject(position);
            newObject.GetComponent<TimedObject>().SetPool(pool);
        }
    }
}
