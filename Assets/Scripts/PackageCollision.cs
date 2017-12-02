using UnityEngine;

public class PackageCollision : MonoBehaviour
{
	public int points;

	private void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag(TagConstants.PACKAGE)) {
			other.gameObject.tag = TagConstants.UNTAGGED;
			CommonObjects.GetGameController().UpdateScore (points);
		}
	}

}
