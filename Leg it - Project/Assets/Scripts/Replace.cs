using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replace : MonoBehaviour {

    public GameObject replacement;
    public Vector3 addXYZ;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            Instantiate(replacement, transform.position - addXYZ, transform.rotation);
        }


    }
}
