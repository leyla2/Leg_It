using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingROck : MonoBehaviour {

    Rigidbody2D [] myRigid;


    // Use this for initialization
    void Start () {
        myRigid = GetComponentsInChildren<Rigidbody2D>();

        foreach (Rigidbody2D fall in myRigid)
        {
            fall.isKinematic = true;
        }

           
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            foreach (Rigidbody2D fall in myRigid)
            {
                fall.isKinematic = false;
            }
        }
    }
}
