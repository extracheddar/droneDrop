using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrust : MonoBehaviour {

    private Rigidbody rb;

    public float latSpeed = 5f;
    public float forwardSpeed = 10f;

    void Start () {
        rb = GetComponent<Rigidbody>();
    }

    void Update () {
        float right = 0f;
        if (Input.GetKey (KeyCode.LeftArrow)) {
            right = -1f;
        } else if (Input.GetKey (KeyCode.RightArrow)) {
            right = 1f;
        }
        Vector3 movement = new Vector3 (right * latSpeed, forwardSpeed, 0.0f);
        rb.AddForce (movement);
    }
}