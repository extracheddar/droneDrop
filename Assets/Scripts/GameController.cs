using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
	public Text scoreText;
	public Text doneScoreText;
	public Text doneTitle;
	public Button playPauseButton;
	public Button restartButton;
	public GameObject directions;
	public GameObject done;
	public Image doneObjectiveCheckBox;
	public Image doneBonusCheckBox;
	public Sprite imagePlay;
	public Sprite imagePause;
	public Sprite checkBox;
	public Sprite xBox;
	public int deliveriesNeeded = 3;
	public int bullseyesNeeded = 3;


	private int score = 0;
	private int bullseyes = 0;
	private int deliveries = 0;


	void Start(){
		CommonObjects.Refresh();
		directions.SetActive (true);
	}

	public int GetScore () {
		return score;
	}

	public int Bullseye(){
		bullseyes += 1;
		return bullseyes;
	}

	public int UpdateScore(int points){
		deliveries += 1;
		score += points;
		scoreText.text = "Score: " + score;
		doneScoreText.text = "Your Score: " + score;
		return score;
	}

	public void EndGame () {
		CommonObjects.GetThrust().DisableThrust();
		scoreText.gameObject.SetActive (false);

		if (deliveries >= deliveriesNeeded) {
			doneTitle.text = "YOU WIN!";
			doneObjectiveCheckBox.sprite = checkBox;
		} else {
			doneTitle.text = "YOU FAIL!";
			doneObjectiveCheckBox.sprite = xBox;
		}

		if (bullseyes >= bullseyesNeeded) {
			doneBonusCheckBox.sprite = checkBox;
		} else {
			doneBonusCheckBox.sprite = xBox;
		}


		done.SetActive (true);
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
		scoreText.gameObject.SetActive (true);
		CommonObjects.GetThrust ().EnableThrust ();
	}

}
