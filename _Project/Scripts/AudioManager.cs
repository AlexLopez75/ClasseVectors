using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource audioSource;

    private void Awake()
    {
        // Patrón Singleton estricto con persistencia entre escenas
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // ¡Esto evita que se borre al cambiar de nivel!
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    void Start()
    {
        // Aseguramos la referencia al AudioSource si no está asignada en el inspector
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }

        if (audioSource == null)
        {
            Debug.LogError("¡ERROR! El AudioManager no tiene un componente AudioSource asignado.");
        }
    }

    public void PlayCoinSound(AudioClip clip)
    {
        if (clip != null && audioSource != null)
        {
            // Forzamos el volumen al máximo por si acaso
            audioSource.volume = 1f;
            audioSource.PlayOneShot(clip);
            Debug.Log("Reproduciendo sonido con éxito: " + clip.name);
        }
    }
}
