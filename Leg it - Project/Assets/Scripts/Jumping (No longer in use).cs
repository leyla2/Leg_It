//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Jumping : MonoBehaviour {

    

//    [SerializeField] //allow the fields to be determined in Unity. 
//    private Transform[] feetPoints;

//    [SerializeField]
//    private float groundRadius;

//    [SerializeField]
//    private LayerMask GroundChecker;

//    private bool isGrounded;
//    private bool jump;
//    private float jumpForce; 

//	void Start () {
//        Rigidbody RigidBod = GetComponent<Rigidbody>();
//    }
	
//	// Update is called once per frame
//	void Update () {
        
//        isGrounded = IsGrounded(); //boolean is equal to outcome of boolean function.

//        if (isGrounded && jump)
//        {
//            isGrounded = false; //once you jump, you aren't grounded and isGrounded boolean is false. 
//            RigidBod.AddForce(new Vector2(0, jumpForce));
//        }

//        if (input.GetKeyDown(KeyCode.UP)) //if up key is pressed
//        {
//            jump = true; 
//        }
//    }

//    private bool IsGrounded()
//    {

//        if(RigidBod.velocity.y <= 0)
//        {

//            foreach(Transform point in feetPoints)
//            {
//                Collider2D[] colliders = Physics2D.OverlapCircleAll(point.position, groundRadius, GroundChecker); //array to contain all colliders groundpoints have collided with. 

//                for(int i = 0; i < colliders.Length; i++)
//                {

//                    if(colliders[i].gameObject != gameObject) //if we are colliding with a game object different from the player object
//                    {

//                        return true; //true to colliding. 
//                    }
//                }

//            }//end of foreach
//        }
//        return false; //reset to not colliding to allow jumping to start.  

       

//    }
//}
