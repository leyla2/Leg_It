using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingPlatform : MonoBehaviour {

    Rigidbody2D myRigid;
    public float fallingSpeed;
    public float destroyTimer;
    // Use this for initialization
    void Start () {

        myRigid = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            myRigid.velocity = new Vector3(0, -fallingSpeed, 0);
            Destroy(gameObject, destroyTimer);
        }
    }
}
