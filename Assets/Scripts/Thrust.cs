using System.Collections;
using System.Collections.Generic;
using Microsoft.Win32;
using UnityEngine;

public class Thrust : MonoBehaviour
{

    public GameObject ground;
    public float latSpeed = 5f;
    public float forwardSpeed = 10f;
    
    private Rigidbody rb;
    private bool generatingThrust = true;
    private float minBounds;
    private float maxBounds;

    void Start () {
        rb = GetComponent<Rigidbody>();
        Renderer sizeRenderer = ground.GetComponent<Renderer>();
        minBounds = sizeRenderer.bounds.min.x + 5;
        maxBounds = sizeRenderer.bounds.max.x - 5;
    }

    void Update () {
		if (generatingThrust && Time.timeScale == 1)
        {
            rb.AddForce (GetMovement());            
        }
    }

    void FixedUpdate () {
        float zVal = rb.position.z;
        float xVal = rb.position.x;
        
        rb.position = new Vector3 
        (
            Mathf.Clamp (xVal, minBounds, maxBounds), 
            rb.position.y,
            zVal
        );

        if (xVal <= minBounds || xVal >= maxBounds)
        {
            rb.velocity = new Vector3
            (
                0,
                rb.velocity.y
            );
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