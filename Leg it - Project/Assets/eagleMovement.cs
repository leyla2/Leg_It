using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagleMovement : MonoBehaviour {

    Animator fly;
    bool alwaysFlying; 

	void Start () {
        fly = GetComponent<Animator>();
        alwaysFlying = true; 
	}
	


	void Update () {

        if (alwaysFlying)
        {

            fly.SetBool("flying", true);
        }

	}
}
