using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {


    [SerializeField]
   Slider HealthBar;
    [SerializeField]
   Text healthValue;

    public GameObject DeathUI;

    static float maxHealth = 100f; //i know this doesn't need to be static because it's always 100
    static float CurrentHealth; // trying to make this static to allow scene to change and keep health unaffected.

    Movement player;//allow to use the variables from the movement class.
    MovementSlide cowgirl;
    public GameObject BloodParticle;
    public GameObject RespawnParticle; //This will be moved once I have a respawn location
    //enemyMainController enemy;

    Animator anim;

    void Start () {
        anim = GetComponent<Animator>();

        //enemy = GetComponent<enemyMainController>();
        player = GetComponent<Movement>();

        HealthBar.value = maxHealth;
        CurrentHealth = HealthBar.value;
        cowgirl = GetComponent<MovementSlide>();




    }

    //void Awake()
    //{

    //        DontDestroyOnLoad(this.gameObject);
      
    //        Debug.Log("Awake: " + this.gameObject);
        
    //}

    // Update is called once per frame
    void Update () {
        
        healthValue.text = CurrentHealth.ToString() + "%";
        Death();
        
    }

    

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "damager")
        {
            
            HealthBar.value -= 1f;
            CurrentHealth = HealthBar.value;
            Instantiate(BloodParticle, gameObject.transform.position, gameObject.transform.rotation);//make a copy of bloodparticle in this position and rotation, of the player when it hits the game object. 

        }
        if (collision.gameObject.tag == "hell")
        {

            HealthBar.value -= 100f;
            CurrentHealth = HealthBar.value;
           
        }

        if (collision.gameObject.tag == "eagle")
        {

            HealthBar.value -= 5f;
            CurrentHealth = HealthBar.value;
            Instantiate(BloodParticle, gameObject.transform.position, gameObject.transform.rotation);//make a copy of bloodparticle in this position and rotation, of the player when it hits the game object. 

        }

        if (collision.gameObject.tag == "LightDamage")
        {

            HealthBar.value -= 0.3f;
            CurrentHealth = HealthBar.value;
            Instantiate(BloodParticle, gameObject.transform.position, gameObject.transform.rotation);//make a copy of bloodparticle in this position and rotation, of the player when it hits the game object. 

        }

        if (collision.gameObject.tag == "MediumDamage")
        {

            HealthBar.value -= 0.6f;
            CurrentHealth = HealthBar.value;
            Instantiate(BloodParticle, gameObject.transform.position, gameObject.transform.rotation);//make a copy of bloodparticle in this position and rotation, of the player when it hits the game object. 

        }

        if (collision.gameObject.tag == "HeavyDamage")
        {

            HealthBar.value -= 1f;
            CurrentHealth = HealthBar.value;
            Instantiate(BloodParticle, gameObject.transform.position, gameObject.transform.rotation);//make a copy of bloodparticle in this position and rotation, of the player when it hits the game object. 

        }
    }

    public void Death()// going to try and respawn location here
    {
        if (CurrentHealth <= 0)
        {

            anim.SetBool("death", true);
            player.enabled = false;
            cowgirl.enabled = false;
            DeathUI.gameObject.SetActive(true);

           // Instantiate(BloodParticle, player.transform.position, player.transform.rotation);//make a copy of bloodparticle in this position and rotation, of the player's. 

           // player.transform.position = new Vector2(50, 0);//respawn to a new location
        }
       
    }

    public void addDamage(float damage)
    {
        if (damage <= 0)

            return;
        CurrentHealth -= damage;
        

    }

    public void HealthIncrease(float health)
    {
        CurrentHealth = CurrentHealth + health;
        if(CurrentHealth > maxHealth)
        {
            CurrentHealth = maxHealth;
        }
       


    }

}
