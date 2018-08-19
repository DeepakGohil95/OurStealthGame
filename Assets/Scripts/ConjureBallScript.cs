using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConjureBallScript : MonoBehaviour {

	public Rigidbody ballObject;
    public Transform ballThrowOrigin;

    public bool ballIsConjured = false;

	// Use this for initialization
	void Start () {
		
		bool ballIsConjured = false;

	}
	
	// Update is called once per frame
	void Update () {

		if ( Input.GetButtonDown("ConjureBall") && ballIsConjured == false){

            ballIsConjured = true;

            transform.GetChild(0).gameObject.SetActive(true);

        } else if ( Input.GetButtonDown("ConjureBall") && transform.GetChild(0).gameObject.activeSelf){

            ballIsConjured = false;

            transform.GetChild(0).gameObject.SetActive(false);

            //add initial velocity + control of velocity if possible? maybe with right analogue stick or alternate Vertical/Horizontal
            //to add player control - create a float variable with a min and max value - make the value of this float increase/decrease through right analogue stick/ up & down arrow keys 
            Rigidbody ballInstance;
            ballInstance = Instantiate(ballObject, ballThrowOrigin.position, ballThrowOrigin.rotation) as Rigidbody;
            ballInstance.AddForce(ballThrowOrigin.forward * 500);
            ballInstance.AddForce(ballThrowOrigin.up * 500);

        }
	}
}
