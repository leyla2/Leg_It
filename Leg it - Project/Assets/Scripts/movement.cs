using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    float baseSpeed = 1;
    public float speed; //player speed, able to change this within the game. 
    public float jump;

    private Rigidbody2D myRigBod;

    private bool grounded;
    public Transform groundChecker;
    public float groundRadius;

    public LayerMask floorLocator; //will be allocated to the ground layer in my game. 
    private Animator anim; //refers to the animator in Unity

    public float speedMult; //what to increase running speed by
    public float speedIncrease; // how much to increase milestone by
   private float speedIncreaseNow; // milestone to start increasing speed

    private Collider2D myCol;

    public GameObject spawnMe;
    public GameObject here;
   
    void Start () {

        myRigBod = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        myCol = GetComponent<Collider2D>(); //get animator component attached to the player
    }


    void Update () {

        anim.SetFloat("verticalSpeed", GetComponent<Rigidbody2D>().velocity.y);
        baseSpeed = Input.GetAxis("Horizontal");// sets basespeed to whatever the movement from keys are +1 or -1 on the axis'.

        //grounded = Physics2D.IsTouchingLayers(myCol, floorLocator); //if these two are touching, grounded = true

        grounded = Physics2D.OverlapCircle(groundChecker.position, groundRadius, floorLocator);


        if (transform.position.x > speedIncreaseNow)
        {
            speedIncreaseNow += speedIncrease;//milestone increases, until next speed is accomplished.
            speedIncreaseNow = speedIncreaseNow * speedMult; // increases milestone position the same ratio as speed increases. 
            speed *= speedMult;//multiply running speed.
            

        }

         myRigBod.velocity = new Vector2(baseSpeed* speed, myRigBod.velocity.y); //move X axis by 1*speed


        if (Input.GetKey(KeyCode.RightArrow))//if right arrow is held down.
        {

            transform.Translate((Input.GetAxis("Horizontal") * Time.deltaTime) * speed, 0f, 0f); //add to x axis 

        }//end of running 


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (grounded)//only jump if player grounded
            {
                myRigBod.velocity = new Vector2(myRigBod.velocity.x, jump);
                
            }
        }////end of if statement


        anim.SetFloat("run", myRigBod.velocity.x); //get run float from unity and set it to equal the x  veloctiy of the rigidbody.
        anim.SetBool("touchingGround", grounded);
    }



    void OnTriggerEnter2D(Collider2D col)//if setting 'onTrigger' and collides with collider.
    {
        if(col.gameObject.tag == "jumpThrough")
        {

            Instantiate(spawnMe, here.transform.position, here.transform.rotation);
        }

       

    }

    

    void OnTriggerExit2D()
    {
        
    }
}
