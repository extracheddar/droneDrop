using DefaultNamespace;
using UnityEngine;

public class PackageCollision : MonoBehaviour
{
	public bool dropZoneEnabled = true;
	
	private GameController gameController;
	private Lot lot;

	public int points;

	private GameController GetGameController () {
		return gameController ?? (gameController = GameObject.FindGameObjectWithTag(TagConstants.GAME_CONTROLLER)
			       .GetComponent<GameController>());
	}

	private Lot GetLot () {
		return lot ?? (lot = GetComponentInParent<Lot>());
	}

	private void OnTriggerEnter(Collider other) 
	{
		if (!DropZoneEnabled())
		{
			return;
		}
		
		GetGameController().AddScore(points);
		Debug.Log(GetGameController().GetScore());
	}

	private bool DropZoneEnabled () {
		return dropZoneEnabled && GetLot().dropZoneEnabled;
	}
}
