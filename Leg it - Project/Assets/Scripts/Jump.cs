using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    public float speed;
    public float jump;
    bool running = false; 
    float moveVel;
    bool grounded = false;
    Animator anim; 



	void Start () {
        anim = GetComponent<Animator>();
	}
	
	void Update () {
       
        //jumping
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) //if w or up is pressed...
        {
            if (grounded)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump); //x value stays the same and y is increased by jump
               // anim.SetBool("jump", false);
            }
        }

        //running 
        if (!running && Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            running = true;
            anim.SetBool("Run", true);
        }

        if(Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
        {
            running = false;
            anim.SetBool("Run", false);

        }

       // running = false;
    }

    void OnTriggerEnter2D()//if setting 'onTrigger' and collides with collider.
    {
            grounded = true;
        anim.SetBool("jump", false);


    }

    void OnTriggerExit2D()
    {
        
            grounded = false;
        anim.SetBool("jump", true);
    }
}
