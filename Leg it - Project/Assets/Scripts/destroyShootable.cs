using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyShootable : MonoBehaviour {

    public GameObject snowEffect;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "bullet")
        {
            Destroy(gameObject);
            Instantiate(snowEffect, transform.position, transform.rotation);
        }

        
    }
}
