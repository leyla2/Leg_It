using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGeneration : MonoBehaviour {

    public GameObject platform; //original platform to duplicate
    public Transform generatePoint;// start generating platforms from last platform point
    public float distance; // distance to be added to x-axis after each platform is built.
    private float pWidth;

    public float distanceMin;
    public float distanceMax;

   // public GameObject[] platformArray; //platform array to create different looking platforms at random
    private int platformSelection; //for randomly selecting platforms.
    private float[] pWidths; // widths between each platforms

    public ObjectPool[] objectPool;
    private float minHeight;

	void Start () {
        // pWidth = platform.GetComponent<BoxCollider2D>().size.x; //duplicate actual platform width.
        pWidths = new float[objectPool.Length];//set array same length as platform array.
        for(int i =0; i< objectPool.Length; i++)
        {
            pWidths[i] = objectPool[i].ObjectToPool.GetComponent<BoxCollider2D>().size.x; //get x value of object in the array list

        }//end of for loop
	}
	

	void Update () {
		
        if(transform.position.x < generatePoint.position.x)
        {

            distance = Random.Range(distanceMin, distanceMax);

            platformSelection = Random.Range(0, objectPool.Length); // turn int into array length

            transform.position = new Vector3(transform.position.x + (pWidths[platformSelection]/2 )+ distance, transform.position.y, transform.position.z); //move generator to the right, add space amount equal to current platform

            //Instantiate(objectPool[platformSelection], transform.position, transform.rotation); //create new platform from array, random selection

            GameObject newPlat = objectPool[platformSelection].GetPooledObject();
            newPlat.transform.position = transform.position;
            newPlat.transform.rotation = transform.rotation;
            newPlat.SetActive(true);

            transform.position = new Vector3(transform.position.x + (pWidths[platformSelection] / 2) , transform.position.y, transform.position.z); //add a half a platform more of space


        }

    }//end of update
}
