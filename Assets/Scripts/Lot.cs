using UnityEngine;

public class Lot : MonoBehaviour
{
	public bool dropZoneEnabled;
	public GameObject landingZone;

	void Start () {
		UpdateDropZones(dropZoneEnabled);
	}

	public void UpdateDropZones (bool enabledFlag) {
		foreach (BoxCollider boxCollider in GetComponentsInChildren<BoxCollider>())
		{
			boxCollider.enabled = enabledFlag;
		}
		landingZone.SetActive(enabledFlag);
	}	
}
