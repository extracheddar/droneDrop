using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour
{
	private Rigidbody rigidBody;
	private GameController gameController;
	private bool hasCollided;
	
	public void ApplyForce (Vector3 force) {
		GetRigidBody().AddForce(force, ForceMode.Impulse);
	}

	private Rigidbody GetRigidBody () {
		return rigidBody ?? (rigidBody = GetComponent<Rigidbody>());
	}
}
