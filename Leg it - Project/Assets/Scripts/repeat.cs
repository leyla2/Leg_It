using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//THIS SCRIPT IS FOR THE BACKGROUND, ADDED TO QUAD OBJECT.

public class repeat : MonoBehaviour {
    public float speed;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 offset = new Vector2(Time.time * speed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}


