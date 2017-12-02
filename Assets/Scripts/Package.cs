using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour
{

	private float forwardThrust;

	// Use this for initialization
	void Start () {
		forwardThrust = 5f;
		//TODO set forward thrust
		//TODO find way to have thrust decay
	}
	
	// Update is called once per frame
	void Update () {
		if (forwardThrust <= 0)
		{
			forwardThrust = 0;
		}
		else
		{
			transform.Translate(Vector3.up * (Time.deltaTime * forwardThrust));
			forwardThrust = forwardThrust - 1f * Time.deltaTime;			
		}
		
	}
}
