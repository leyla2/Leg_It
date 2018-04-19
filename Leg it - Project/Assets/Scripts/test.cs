using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    public GameObject poop;
    public float poops;

	void Start ()
    {
		
	}
	
	
	void Update ()
    {
		
	}

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("works!");
            Instantiate(poop, gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}
