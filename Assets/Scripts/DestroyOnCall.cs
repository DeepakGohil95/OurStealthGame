using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCall : MonoBehaviour {
	
	public GameObject player;

	private ConjureWall conjureWallScript;

	private bool wallIsConjuredBool;

	// Use this for initialization
	void Start () {

		conjureWallScript = player.GetComponent<ConjureWall>();

		wallIsConjuredBool = conjureWallScript.wallIsConjured;
		
	}
	
	// Update is called once per frame
	void Update () {

		if ( ( Input.GetButtonDown("Cancel") || Input.GetButtonDown("ConjureWall") )  &&  wallIsConjuredBool == false)
		{

			Destroy (gameObject);
			print ("Wall destruction working");

		}
	}
}
