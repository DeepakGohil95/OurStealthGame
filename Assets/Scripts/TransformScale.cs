using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformScale : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		
		


		if (transform.localScale.y <= 10)
		{
			transform.localScale += new Vector3 (0,0.1f,0);
		}	
		else if (transform.localScale.y >=10){

			transform.localScale = new Vector3 (5,11,1);

		}
	}
}
