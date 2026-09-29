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
            // 1. Sumamos los puntos en el GameManager
            if (GameManager.Instance != null)
            {
                GameManager.Instance.AddScore(amount);
            }

            // 2. Reproducimos el sonido mediante el Singleton AudioManager
            if (AudioManager.instance != null && coinSound != null)
            {
                AudioManager.instance.PlayCoinSound(coinSound);
            }
            else
            {
                Debug.LogWarning("No se pudo reproducir el sonido de la moneda: AudioManager o AudioClip nulo.");
            }

            // 3. Destruimos la moneda
            Destroy(gameObject);
        }
    }
}
