using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public float offset = 0f;

    private GameObject player;

    void Start () {
        player = GameObject.FindGameObjectWithTag ("Player");
    }

    void Update () {
		
    }

    void LateUpdate ()
    {
        transform.position = new Vector3 (transform.position.x, transform.position.y, player.transform.position.z + offset);
    }

}