using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public Movement player;
    private Vector3 lastPlayerPos;
    private float distanceToMove;

	void Start () {
        player = FindObjectOfType<Movement>();
        lastPlayerPos = player.transform.position;//make the private vector equivalent to player's position

    }

    // Update is called once per frame
    void Update () {
        distanceToMove = player.transform.position.x - lastPlayerPos.x;//current position minus the last position 
        transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);


        lastPlayerPos = player.transform.position;//make the private vector equivalent to player's position

    }
}
