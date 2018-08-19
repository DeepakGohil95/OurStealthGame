using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConjureWall : MonoBehaviour {

	public GameObject wallObj;

	public bool wallIsConjured = false;

	[Range(5f,15f)]
	public float wallConjureDistance;

	// Use this for initialization
	void Start () {

		wallIsConjured = false;
		
	}
	
	// Update is called once per frame
	void Update () {

		 if ( Input.GetButtonDown("ConjureWall") ){

			wallIsConjured = true;

			 //disable objectThrowingRecall script
			 //playerBallObject.enabled = false
			Instantiate (wallObj, transform.position+(transform.forward*wallConjureDistance), transform.rotation);

		 } 
	}
}
