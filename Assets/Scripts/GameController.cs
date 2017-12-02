using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	public Text scoreText;

	private int score;

	public int GetScore () {
		return score;
	}

	public int UpdateScore(int points){
		score += points;
		scoreText.text = "Score: " + score;
		return score;
	}

	public void EndGame () {
		CommonObjects.GetThrust().DisableThrust();
	}

}
