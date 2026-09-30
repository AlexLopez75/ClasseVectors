using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollecter : MonoBehaviour
{
    [SerializeField] private int amount = 1;
    [SerializeField] private AudioClip coinSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            GameManager.Instance.AddScore(amount);
            AudioManager.instance.PlayCoinSound(coinSound);
            Destroy(gameObject);
        }
    }
}
