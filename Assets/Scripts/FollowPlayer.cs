using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public float offset = 0f;

    private GameObject player;

    void Start () {
        player = GameObject.FindGameObjectWithTag (TagConstants.PLAYER);
    }

    void LateUpdate ()
    {
        transform.position = new Vector3 (transform.position.x, player.transform.position.y + offset, transform.position.z);
    }

}