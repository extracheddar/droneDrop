using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour
{
	private Rigidbody rigidBody;
	private bool hasCollided;
	
	public void ApplyForce (Vector3 force) {
		Vector3 scaledForce = Vector3.Scale(force, new Vector3(12.5f, 20f));
		GetRigidBody().AddForce(scaledForce, ForceMode.Impulse);
	}

	private Rigidbody GetRigidBody () {
		return rigidBody ?? (rigidBody = GetComponent<Rigidbody>());
	}
}
