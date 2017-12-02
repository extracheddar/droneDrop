using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDropScript : MonoBehaviour
{
	public Transform packageSpawn;
	public GameObject packagePrefab;
	public float forwardSpeed;
	public int rateOfDrop;
	private DateTime lastDropped;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (canDropAnotherPackage())
			{
				dropPackage();
			}
		}
	}

	void dropPackage () {
		GameObject package = Instantiate(packagePrefab, packageSpawn.position, packageSpawn.rotation);
		Package packageScript = (Package) package.GetComponent(typeof(Package));
		packageScript.forwardThrust = forwardSpeed;
		Destroy(package, 10f);
		lastDropped = DateTime.Now;
	}

	bool canDropAnotherPackage () {
		return lastDropped <= DateTime.Now.Subtract (TimeSpan.FromMilliseconds (rateOfDrop));
	}
}
