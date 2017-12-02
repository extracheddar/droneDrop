using DefaultNamespace;
using UnityEngine;

public class PackageCollision : MonoBehaviour
{
	private GameController gameController;

	public int points = 0;

	private GameController GetGameController () {
		return gameController ?? (gameController = GameObject.FindGameObjectWithTag(TagConstants.GAME_CONTROLLER)
			       .GetComponent<GameController>());
	}

	private void OnTriggerEnter(Collider other) 
	{
		GetGameController().AddScore(50);
		Debug.Log ("collision:" + gameObject.tag);
		Debug.Log ("add " + points + " points");

	}
}
