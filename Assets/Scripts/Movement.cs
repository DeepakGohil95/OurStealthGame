using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	 public float walkSpeed = 10.0F;
     public float walkRotationSpeed = 100.0F;
	 public float runSpeed = 20.0F;
     public float runRotationSpeed = 100.0F;
	 public float crouchSpeed = 5.0F;
     public float crouchRotationSpeed = 100.0F;

	 public bool isWalk = true;
	 public bool isRun = false;
	 public bool isCrouch = false;

	 public GameObject player;

	// Use this for initialization
	void Start () {


	 bool isWalk = true;
	 bool isRun = false;
	 bool isCrouch = false;

		
	}
	
	// Update is called once per frame
	void Update () {
		



		//
		if ( Input.GetButton("Crouch") && isRun == false )
		{	
			//deactivates footsteps
			player.GetComponent<InstantiateWalkStep>().enabled = false;
			player.GetComponent<InstantiateRunStep>().enabled = false;
			

			isWalk = false;
			isRun = false;
			isCrouch = true;

		} else  if (Input.GetButton("Run")) {

			//reactivates footsteps
			player.GetComponent<InstantiateWalkStep>().enabled = false;
			player.GetComponent<InstantiateRunStep>().enabled = true;

			isWalk = false;
			isRun = true;
			isCrouch = false;

		} else {

			//reactivates footsteps
			player.GetComponent<InstantiateWalkStep>().enabled = true;
			player.GetComponent<InstantiateRunStep>().enabled = false;

			isWalk = true;
			isRun = false;
			isCrouch = false;

		}
		//




		//
		if (isRun == true){

			Running();

			transform.localScale = new Vector3(1, 2, 1);

			
		} else if (isCrouch == true){

			Crouching();

			transform.localScale = new Vector3(1, 1, 1);

		} else {  //walking = true

			Walking();

			transform.localScale = new Vector3(1, 2, 1);

		}
		//
		
	}



	void Walking() {

		//Walking
		float translation = Input.GetAxis("Vertical") * walkSpeed; //variable declared
        float rotation = Input.GetAxis("Horizontal") * walkRotationSpeed; //variable declared
        translation *= Time.deltaTime; // x *= y equals x * y
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

		

	}

	void Running(){

		//Running
		float translation = Input.GetAxis("Vertical") * runSpeed; //variable declared
        float rotation = Input.GetAxis("Horizontal") * runRotationSpeed; //variable declared
        translation *= Time.deltaTime; // x *= y equals x * y
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

	}

	void Crouching(){

		//Crouching
		float translation = Input.GetAxis("Vertical") * crouchSpeed; //variable declared
        float rotation = Input.GetAxis("Horizontal") * crouchRotationSpeed; //variable declared
        translation *= Time.deltaTime; // x *= y equals x * y
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

	}

	    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "obstacle")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("collided with obstacle");
        }
    }


}
