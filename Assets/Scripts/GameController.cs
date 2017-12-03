using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
	public Text scoreText;
	public Text doneScoreText;
	public Text doneTitle;
	public Button playPauseButton;
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
		if (CommonObjects.showIntro) {
			directions.SetActive (true);
		} else {
			BeginGame ();
		}
	}

	public int GetScore () {
		return score;
	}

	public int Bullseye(){
		bullseyes += 1;
		if (bullseyes >= bullseyesNeeded) {
			doneBonusCheckBox.sprite = checkBox;
		} else {
			doneBonusCheckBox.sprite = xBox;
		}
		return bullseyes;
	}

	public int UpdateScore(int points){
		score += points;
		scoreText.text = "Score: " + score;
		doneScoreText.text = "Your Score: " + score;
		if (points > 0) {
			deliveries += 1;
		}
		if (deliveries >= deliveriesNeeded) {
			doneTitle.text = "YOU WIN!";
			doneObjectiveCheckBox.sprite = checkBox;
		} else {
			doneTitle.text = "YOU FAIL!";
			doneObjectiveCheckBox.sprite = xBox;
		}
		return score;
	}

	public void EndGame () {
		CommonObjects.GetThrust().DisableThrust();
		scoreText.gameObject.SetActive (false);
		playPauseButton.gameObject.SetActive (false);
		done.SetActive (true);
	}

	public void PlayPauseToggle(){
		bool pause = (Time.timeScale == 0) ? false : true;
		directions.SetActive (pause);
		directions.transform.Find ("Btn_begin").gameObject.SetActive (!pause);
		directions.transform.Find ("Btn_restart").gameObject.SetActive (pause);
		Time.timeScale = !pause ? 1 : 0;
		playPauseButton.image.sprite = (playPauseButton.image.sprite == imagePause) ? imagePlay : imagePause;
	}

	public void Restart(bool showIntro){
		CommonObjects.showIntro = showIntro;
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
