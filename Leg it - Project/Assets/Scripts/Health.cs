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

    private movement player;//allow to use the variables from the movement class.
    public GameObject BloodParticle;
    public GameObject RespawnParticle; //This will be moved once I have a respawn location


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

    public void Death()
    {
        if (CurrentHealth == 0)
        {

            Instantiate(BloodParticle, player.transform.position, player.transform.rotation);//make a copy of bloodparticle in this position and rotation, of the player's. 
            player.transform.position = new Vector2(50, 0);
        }

    }

}
