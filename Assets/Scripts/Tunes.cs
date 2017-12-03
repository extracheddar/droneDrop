using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tunes : MonoBehaviour {

	void Awake() {
//		DontDestroyOnLoad(transform.gameObject);

		DontDestroyOnLoad(this);

		if (FindObjectsOfType (GetType ()).Length > 1) {
			Destroy (gameObject);
		} else {
			GetComponent<AudioSource> ().Play ();
		}
	}

}
