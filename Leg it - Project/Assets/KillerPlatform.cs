using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerPlatform : MonoBehaviour {

    MoveForward moveForward;

	// Use this for initialization
	void Start () {
        
        moveForward = GetComponent<MoveForward>();
        moveForward.speed = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            moveForward.speed = 20f;
        }
    }
}
