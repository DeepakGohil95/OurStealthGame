﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI01 : MonoBehaviour {

	public float moveForce = 0f;
	private Rigidbody rbody;
	public Vector3 moveDir;
	public LayerMask whatIsWall;
	public float maxDistFromWall = 0f;

	// Use this for initialization
	void Start () {

		rbody = GetComponent<Rigidbody>();
		moveDir = ChooseDirection();
		
	}
	
	// Update is called once per frame
	void Update () {

		rbody.velocity = moveDir * moveForce;

		if(Physics.Raycast(transform.position, transform.forward, maxDistFromWall, whatIsWall))
		{
			moveDir = ChooseDirection();
			transform.rotation = Quaternion.LookRotation(moveDir);
		}

		
	}

	Vector3 ChooseDirection()
	{
		System.Random ran = new System.Random();
		int i = ran.Next(0,1);
		Vector3 temp = new Vector3();

		if(i == 0)
		{
			temp = transform.forward;
		}
		else if(i == 1)
		{
			temp = -transform.forward;
		}

		return temp;

	}
}
