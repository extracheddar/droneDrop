using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour
{
	private Rigidbody rigidBody;
	private GameController gameController;
	private bool hasCollided = false;
	
	public void ApplyForce (Vector3 force) {
		GetRigidBody().AddForce(force, ForceMode.Impulse);
	}

	private Rigidbody GetRigidBody () {
		if (rigidBody == null)
		{
			rigidBody = GetComponent<Rigidbody>();
		}

		return rigidBody;
	}

	private GameController GetGameController () {
		if (gameController == null)
		{
			gameController = GameObject.FindGameObjectWithTag("GameController")
				.GetComponent<GameController>();			
		}

		return gameController;
	}

	private void OnCollisionEnter (Collision other) {
		if (hasCollided)
		{
			return;
		}
		
		hasCollided = true;
		Debug.Log("Collision!");
		Debug.Log(other.gameObject.tag);
		
		GetGameController().AddScore(50);
		Debug.Log(GetGameController().GetScore());
	}
}
