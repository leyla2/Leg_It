using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{

 
    public Transform Exit;
    public Transform player; 




    void Start()
    {
     


    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("works");
            player.transform.position = Exit.transform.position;

        }
    }


}