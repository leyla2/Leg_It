using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {


    [SerializeField]
    Slider HealthBar;
    [SerializeField]
    Text healthValue;

    float maxHealth = 100f;
    float CurrentHealth;


    void Start () {

        HealthBar.value = maxHealth;
        CurrentHealth = HealthBar.value;
	}
	
	// Update is called once per frame
	void Update () {
        healthValue.text = CurrentHealth.ToString() + "%";
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "damager")
        {

            HealthBar.value -= 1f;
            CurrentHealth = HealthBar.value;
        }
    }
}
