using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOldPlatforms : MonoBehaviour {


  GameObject DestroyPlatformsHere;



	void Start () {
        DestroyPlatformsHere = GameObject.Find("DestroyPlatformsHere"); 
	}
	
	

	void Update () {
        
		if(transform.position.x < DestroyPlatformsHere.transform.position.x)
        {

            Destroy(gameObject);
        }
	}
}
