using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour {

    public GameObject ObjectToPool;
    public int pooledAmount;
    List<GameObject> pooledObjectList;

	void Start () {
        pooledObjectList = new List<GameObject>();
        
        for(int i = 0; i< pooledAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(ObjectToPool);
            obj.SetActive(false);
            pooledObjectList.Add(obj);// add gameobject to array list

        }	//end of for loop
	}


    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjectList.Count; i++){//loop through array list of objects
            if(!pooledObjectList[i].activeInHierarchy)//question if the object in the list is active or not. 
            {
                return pooledObjectList[i];//use the inactive object
            }

        }
        GameObject obj = (GameObject)Instantiate(ObjectToPool);//create object
        obj.SetActive(false);//set new object to false to be able to use
        pooledObjectList.Add(obj);//add it to the array list
        return obj;//now use the inactive obejct
    }

}
