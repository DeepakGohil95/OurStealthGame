using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateNoise : MonoBehaviour {


	public GameObject noisePrefab;

	//public Transform thisObject;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	  void OnCollisionEnter(Collision collision)
    {
        //Output the Collider's GameObject's name
		Instantiate(noisePrefab, transform.position, Quaternion.identity);
        Debug.Log(collision.collider.name);
    }

}
