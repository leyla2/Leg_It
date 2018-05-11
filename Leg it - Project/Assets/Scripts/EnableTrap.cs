using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableTrap : MonoBehaviour {
    public GameObject RollSaw;

    // Use this for initialization
    void Start () {
       // RollSaw = GameObject.Find("RollingSaw");
        //RollSaw.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

     void OnTriggerEnter2D(Collider2D col)
    {
        RollSaw.SetActive(true);
    }


}
