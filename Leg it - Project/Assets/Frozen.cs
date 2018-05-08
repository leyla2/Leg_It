using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frozen : MonoBehaviour {

    MovementSlide move;
   // public GameObject playerLoc;
    //float PlayerPos;
   // Rigidbody2D CharRigBod;


     void Start()
    {
        move = GetComponent<MovementSlide>();
        //Invoke("RestartPlayer", 3);
        //PlayerPos = GameObject.FindGameObjectWithTag("Player").transform.position.x;
        //CharRigBod = playerLoc.GetComponent<Rigidbody2D>();
    }



    IEnumerator OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            MovementSlide move = col.GetComponent<MovementSlide>();
            moveBack moveBack = col.GetComponent<moveBack>();
            move.enabled = false;
            moveBack.enabled = false;
            yield return new WaitForSecondsRealtime(3);
            move.enabled = true;
            moveBack.enabled = true;
        }
    }

    //void OnTriggerEnter2D(Collider2D col)
    //{
    //    //CharRigBod.isKinematic = true;
    //    //if (gameObject.CompareTag("Player"))
    //    //{

    //    move.speed = 0;
    //    print("speeeed");
    //    //CharRigBod.transform.position == new Vector2(0, 0);

    //    //    //  yield return new WaitForSecondsRealtime(3.5f); //Wait for 3.5 secs
    //    //    //print()
    //    //  //  move.enabled = false;

    //    //}
    //}



    //void RestartPlayer()
    //{
    //    PlayerPos += 20;
    //    move.enabled = false;

    //}


}
