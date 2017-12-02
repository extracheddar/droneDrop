using DefaultNamespace;
using UnityEngine;

public class PackageCollision : MonoBehaviour
{
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
		if (!LotIsEnabled())
		{
			return;
		}
		
		GetGameController().AddScore(points);
		Debug.Log(GetGameController().GetScore());
	}

	private bool LotIsEnabled () {
		return GetLot().dropZoneEnabled;
	}
}
