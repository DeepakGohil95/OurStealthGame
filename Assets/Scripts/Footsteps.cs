using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour {

	public float lifetime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.localScale -= new Vector3 (0.1f,0,0.1f);

		Destroy(gameObject, lifetime);

	}
}
