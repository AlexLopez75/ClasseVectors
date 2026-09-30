using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
	[SerializeField] public GameObject pauseButton;
    [SerializeField] public GameObject pauseMenu;
	public bool isPaused;

    public void OpenPause() 
    {
		Time.timeScale = 0;
        pauseButton.SetActive(false);
		pauseMenu.SetActive(true);
		isPaused = true;
	}

	public void ClosePause() 
    {
		Time.timeScale = 1;
		pauseButton.SetActive(true);
		pauseMenu.SetActive(false);
		isPaused = false;
	}

    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (!isPaused)
			{
				OpenPause();
			}
			else
			{
				ClosePause();
			}
		}

	}
}
