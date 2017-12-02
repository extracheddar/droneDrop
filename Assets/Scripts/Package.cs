using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour
{
	private Rigidbody rigidBody;

	public void ApplyForce (Vector3 force) {
		GetRigidBody().AddForce(force, ForceMode.Impulse);
	}

	private Rigidbody GetRigidBody () {
		if (rigidBody == null)
		{
			rigidBody = GetComponent<Rigidbody>();
		}

		return rigidBody;
	}
}
