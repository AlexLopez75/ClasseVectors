using UnityEngine;

public class TimedObject : MonoBehaviour
{
    [SerializeField] private float lifeTime = 5f;

    private ObjectPool pool;
    private float timer;

    public void SetPool(ObjectPool newPool)
    {
        pool = newPool;
    }

    void OnEnable()
    {
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= lifeTime)
        {
            pool.ReturnObject(gameObject);
        }
    }
}
