using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageCollision : MonoBehaviour {

	public int points = 0;
	
	void Start () {
		
	}

	void Update () {
		
	}

	void OnTriggerEnter(Collider other) 
	{
		Debug.Log ("collision:" + gameObject.tag);
		Debug.Log ("add " + points + " points");

	}
}
