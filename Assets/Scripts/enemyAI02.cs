using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI02 : MonoBehaviour {

	public float rotationSpeed;

	public float moveSpeed;

	[Range(1f,100f)]
	public float rayDistance;	

	private Rigidbody rbody;

	public bool enemyGoBack;
	public bool enemyGoFwd;
	public bool enemyTurnRight;
	public bool enemyTurnLeft;


	// Use this for initialization
	void Start () {

		rbody = GetComponent<Rigidbody>();



		enemyGoBack = false;
		enemyGoFwd = true;
		enemyTurnRight = false;
		enemyTurnLeft = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		//rotates left
		//transform.Rotate( Vector3.down * rotationSpeed * Time.deltaTime);
	
		


		if(enemyGoFwd == true)
		{
			transform.position += (Vector3.forward * moveSpeed * Time.deltaTime);
		} 
		else if(enemyGoBack == true)
		{
			transform.position += (Vector3.back * moveSpeed * Time.deltaTime);
		}
		





		// Bit shift the index of the layer (10) to get a bit mask
		int layerMask = 1 << 10;
		// Casts rays only against colliders in layer 10, player layer
		RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, rayDistance, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * rayDistance, Color.red);
            Debug.Log("Did Hit");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * rayDistance, Color.green);
            Debug.Log("Did not Hit");
        }

	}


	void OnCollisionEnter(Collision collision)
	{

		//Check to see if the Collider's name is "Chest"
        if (collision.collider.tag == "enemyFlagBack")
        {

			enemyGoFwd = false;
			enemyGoBack = true;
            //Output the message
            Debug.Log("Enemy move back now");
        }


		//Check to see if the Collider's name is "Chest"
        if (collision.collider.tag == "enemyFlagFwd")
        {

			enemyGoFwd = true;
			enemyGoBack = false;
            //Output the message
            Debug.Log("Enemy move forward now");
        }

	}


	


}
