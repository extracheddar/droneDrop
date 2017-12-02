using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	public Text scoreText;

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

}
