using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
	public Text scoreText;
	public Button playPauseButton;
	public Button restartButton;
	public GameObject directions;
	public Sprite imagePlay;
	public Sprite imagePause;

	private int score;

	void Start(){
		Time.timeScale = 0;
	}

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

	public void PlayPauseToggle(){
		Time.timeScale = (Time.timeScale == 0) ? 1 : 0;
		playPauseButton.image.sprite = (playPauseButton.image.sprite == imagePause) ? imagePlay : imagePause;
		restartButton.gameObject.SetActive (Time.timeScale == 0);
	}

	public void Restart(){
		Time.timeScale = 1;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
	}

	public void BeginGame(){
		directions.SetActive (false);
		playPauseButton.gameObject.SetActive (true);
		Time.timeScale = 1;
	}

}
