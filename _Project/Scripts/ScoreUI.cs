using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
	[SerializeField] private TMP_Text scoreText;
	private int score = 0;

	public void AddPoints()
	{
		score = score + 10;
		scoreText.text = "Score: " + score;
	}
}
