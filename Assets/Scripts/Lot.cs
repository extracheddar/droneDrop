using UnityEngine;

public class Lot : MonoBehaviour
{
	public GameObject landingZone;

	public void UpdateDropZones (bool enabledFlag) {
		foreach (BoxCollider boxCollider in GetComponentsInChildren<BoxCollider>())
		{
			boxCollider.enabled = enabledFlag;
		}
		landingZone.SetActive(enabledFlag);
	}	
}
