using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	private int score;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public int GetScore () {
		return score;
	}

	public void AddScore (int amount) {
		score += amount;
	}

	public void RemoveScore (int amount) {
		AddScore(- amount);
	}
}
