using UnityEngine;

public class FinishLine : MonoBehaviour
{	
	private void OnTriggerEnter (Collider other) {
		Debug.Log("Ending game!");
		//TODO stop game via GameController
		CommonObjects.GetThrust().DisableThrust();
	}
}
