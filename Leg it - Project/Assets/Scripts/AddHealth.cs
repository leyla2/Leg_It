using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHealth : MonoBehaviour {

    public float amountToHeal;
    Health health;

	// Use this for initialization
	void Start () {
        health = GetComponent<Health>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            Health health = col.gameObject.GetComponent<Health>();
            health.HealthIncrease(amountToHeal);
            Destroy(gameObject);
        }
    }
}
