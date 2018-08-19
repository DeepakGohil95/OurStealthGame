using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtPlayer : MonoBehaviour {

	GameObject player;

	// Use this for initialization
	void Start () {

		player = GameObject.FindGameObjectWithTag("Player");
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 targetPosition = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
		transform.LookAt(targetPosition);
	}
}
