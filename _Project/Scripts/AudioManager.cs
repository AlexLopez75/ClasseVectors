using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource audioSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayCoinSound(AudioClip clip)
    {
        if (clip != null && audioSource != null)
        {
            audioSource.volume = 1f;
            audioSource.PlayOneShot(clip);
            Debug.Log("Reproduciendo " + clip.name);
        }
    }
}
