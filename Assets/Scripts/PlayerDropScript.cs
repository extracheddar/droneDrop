using System;
using UnityEngine;

public class PlayerDropScript : MonoBehaviour
{
	public Transform packageSpawn;
	public GameObject packagePrefab;
	public int rateOfDrop;
	private DateTime lastDropped;
	private Rigidbody rigidBody;
	private AudioSource audioSource;

	void Start () {
		rigidBody = GetComponent<Rigidbody>();
		audioSource = GetComponent<AudioSource> ();
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && Time.timeScale == 1)
		{
			if (CanDropAnotherPackage() && CommonObjects.GetThrust().IsGeneratingThrust())
			{
				DropPackage();
			}
		}
	}

	void DropPackage () {
		lastDropped = DateTime.Now;
		GameObject package = Instantiate(packagePrefab, packageSpawn.position, packageSpawn.rotation);
		Package packageScript = (Package) package.GetComponent(typeof(Package));
		packageScript.ApplyForce(rigidBody.velocity);
		Destroy(package, 10f);
		audioSource.Play ();
	}

	bool CanDropAnotherPackage () {
		return lastDropped <= DateTime.Now.Subtract (TimeSpan.FromMilliseconds (rateOfDrop));
	}
}
