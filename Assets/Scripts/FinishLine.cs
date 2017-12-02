using UnityEngine;

public class FinishLine : MonoBehaviour
{	
	private void OnTriggerEnter (Collider other) {
		CommonObjects.GetGameController().EndGame();
	}
}
