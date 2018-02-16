using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      
        transform.Translate(-6f * Time.deltaTime, 0, 0);
       
    }
}
