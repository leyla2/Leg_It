using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBack : MonoBehaviour {


	void Start () {
		
	}
	

	void Update () {
      
        transform.Translate(-6f * Time.deltaTime, 0, 0);
       
    }
}
