using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageCollision : MonoBehaviour {
	
	void Start () {
		
	}

	void Update () {
		
	}

	void OnTriggerEnter(Collider other) 
	{
		Debug.Log ("collision:" + gameObject.tag);
	}
}
