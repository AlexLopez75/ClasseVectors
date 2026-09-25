using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int score = 0;
    public int numberOfCoins = 2;

    private void Awake()
    {
        if (Instance != null && Instance != this) 
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void AddScore(int amount) 
    { 
        score += amount;
        Debug.Log(score);
    }

	public void ChangeTo(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}

	public void SetScore(int amount) => score = amount;
    public int GetScore() => score;

    private void Update()
    {
        if (score == numberOfCoins) 
        {
            SceneManager.LoadScene("Level_02");
        }
    }
}
