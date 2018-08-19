using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnRecall : MonoBehaviour {


	public Transform player;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

		if ( Input.GetButtonDown("ConjureBall") && player.transform.GetChild(0).gameObject.activeSelf == false )	{

			Destroy(gameObject);
			print ("ball destruction working");

		}


	}
}
