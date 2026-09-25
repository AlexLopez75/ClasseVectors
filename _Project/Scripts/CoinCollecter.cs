using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollecter : MonoBehaviour
{
    [SerializeField] private int amount = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.AddScore(amount);
            Destroy(gameObject);
        }
    }
}
