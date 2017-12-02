using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	public Text scoreText;
	public Button playPauseBtn;
	public Sprite imagePlay;
	public Sprite imagePause;

	private int score;

	void Start () {
		
	}

	void Update () {
		
	}

	public int GetScore () {
		return score;
	}

	public int UpdateScore(int points){
		score += points;
		scoreText.text = "Score: " + score;
		return score;
	}

	public void PlayPauseToggle(){
		Time.timeScale = (Time.timeScale == 0) ? 1 : 0;
		playPauseBtn.image.sprite = (playPauseBtn.image.sprite == imagePause) ? imagePlay : imagePause;
	}

}
