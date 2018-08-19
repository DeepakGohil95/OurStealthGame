using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithCamera : MonoBehaviour {



	public bool newDeltaObtained;



	/* //////////////////////////////////////////////////////





	// Use this for initialization
	void Start () {
		
	}

	void Update () {
		

		if(newDeltaObtained) 
		{this.gameObject.transform.localRotation *= rotateBy;
		newDeltaObtained = false; } 
		
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		Rotate();
	}


	 public void Rotate (float rotateLeftRight, float rotateUpDown, bool isPlayer)
     {
        
         
         //Unsure of how much below code changes outcome.
         float sensitivity = 0;
         if (isPlayer)
         {
             sensitivity = .5f;
         }
         else
         {
             sensitivity = .25f;
         }
         
         //Get Main camera in Use.
         Camera cam = Camera.main;
         //Gets the world vector space for cameras up vector 
         Vector3 relativeUp = cam.transform.TransformDirection(Vector3.up);
         //Gets world vector for space cameras right vector
         Vector3 relativeRight = cam.transform.TransformDirection(Vector3.right);
 
         //Turns relativeUp vector from world to objects local space
         Vector3 objectRelativeUp = transform.InverseTransformDirection(relativeUp);
         //Turns relativeRight vector from world to object local space
         Vector3 objectRelativeRight = transform.InverseTransformDirection(relativeRight);
         
         rotateBy = Quaternion.AngleAxis(rotateLeftRight / gameObject.transform.localScale.x * sensitivity, objectRelativeUp)
             * Quaternion.AngleAxis(-rotateUpDown / gameObject.transform.localScale.x  * sensitivity, objectRelativeRight);
         
         newDeltaObtained = true;
         
     }




	*/ ////////////////////////////////////////////////////////


}
