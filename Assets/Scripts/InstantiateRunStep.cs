using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateRunStep : MonoBehaviour {

	public float InstantiationTimer;

    public GameObject runstepPrefab;

	public Transform player;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		CreateStep();
		
	}

		void CreateStep(){

			if (Input.GetAxis("Vertical") != 0 ){


				Instantiate(runstepPrefab, player.position, Quaternion.identity);


					InstantiationTimer -= Time.deltaTime;
     				if (InstantiationTimer <= 0)
     				{
         				Instantiate(runstepPrefab, player.position, Quaternion.identity);
         				
     				}

				InstantiationTimer = 2f;

			}
 			
		}

}
