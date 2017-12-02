using DefaultNamespace;
using UnityEngine;

public class PackageCollision : MonoBehaviour
{
	
	private GameController gameController;

	public int points;

	private GameController GetGameController () {
		return gameController ?? (gameController = GameObject.FindGameObjectWithTag(TagConstants.GAME_CONTROLLER)
			       .GetComponent<GameController>());
	}

	private void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag(TagConstants.PACKAGE)) {
			other.gameObject.tag = TagConstants.UNTAGGED;
			GetGameController ().UpdateScore (points);
		}
	}

}
