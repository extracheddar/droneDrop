using UnityEngine;

public class PackageCollision : MonoBehaviour
{
	public int points;
	private AudioSource audioSource;

	void Start(){
		audioSource = GetComponent<AudioSource> ();
	}

	private void OnTriggerEnter(Collider other) 
	{
		
		if (other.gameObject.CompareTag(TagConstants.PACKAGE)) {
			DoCollision (other.gameObject);
		}
	}

	private void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.CompareTag (TagConstants.PACKAGE)) {
			DoCollision (collision.gameObject);
		}
	}

	private void DoCollision(GameObject package){
		package.tag = TagConstants.UNTAGGED;
		CommonObjects.GetGameController().UpdateScore (points);
		audioSource.Play ();
		if (gameObject.CompareTag (TagConstants.LANDING_ZONE)) {
			CommonObjects.GetGameController ().Bullseye ();
		}
		if (transform.parent != null && transform.parent.tag == TagConstants.LOT) {
			DisableLot (transform.parent);
		}
	}

	private  void DisableLot(Transform lot){
		foreach (Transform child in lot) {
			BoxCollider boxCollider = child.GetComponent<BoxCollider> ();
			if (boxCollider != null) {
				boxCollider.enabled = false;
			}
		}
	}
}
