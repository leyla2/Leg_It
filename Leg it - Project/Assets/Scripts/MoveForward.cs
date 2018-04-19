using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public GameObject player;
    public float speed;
    private Transform currentLocation;
    public Transform[] end;
    public int endSelection;

    void Start()
    {
        currentLocation = end[endSelection];
    }

    // Update is called once per frame
    void Update()
    {
        player.transform.position = Vector3.MoveTowards(player.transform.position, currentLocation.position, Time.deltaTime * speed);
        
        if(player.transform.position == currentLocation.position)
        {
            endSelection++;

            if(endSelection == end.Length)
            {

                endSelection = 0;
            }

            currentLocation = end[endSelection];
        }     
    }
}