using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrust : MonoBehaviour {

    private Rigidbody rb;

    public float latSpeed = 5f;
    public float forwardSpeed = 10f;
    private bool generatingThrust = true;

    void Start () {
        rb = GetComponent<Rigidbody>();
    }

    void Update () {
		if (generatingThrust && Time.timeScale == 1)
        {
            rb.AddForce (GetMovement());            
        }
    }

    public Vector3 GetMovement () {
        float right = 0f;
        if (Input.GetKey (KeyCode.LeftArrow)) {
            right = -1f;
        } else if (Input.GetKey (KeyCode.RightArrow)) {
            right = 1f;
        }
        return new Vector3 (right * latSpeed, forwardSpeed, 0.0f);
    }

    public void DisableThrust () {
        generatingThrust = false;
    }

    public void EnableThrust () {
        generatingThrust = true;
    }
}