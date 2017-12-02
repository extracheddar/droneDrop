using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lot : MonoBehaviour
{
	public bool dropZoneEnabled;

	public void UpdateDropZones (bool enabledFlag) {
		dropZoneEnabled = enabledFlag;
		foreach (BoxCollider boxCollider in GetComponentsInChildren<BoxCollider>())
		{
			boxCollider.enabled = enabledFlag;
		}
	}	
}
