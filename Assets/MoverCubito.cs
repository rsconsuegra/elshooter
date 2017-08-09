﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCubito : MonoBehaviour {

	// Use this for initialization
	public float velocidadDespzamiento = 5f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
/*		transform.Translate(new Vector3( 0f , 0f , Input.GetAxis( "Vertical" ) ) * 
			Time.deltaTime 
			* movementSpeed);
		transform.Rotate( new Vector3( 0f , Input.GetAxis( "Horizontal" ) , 0f ) );*/

		if (Input.GetKey(KeyCode.W)) 
		{ 
			this.transform.Translate(Vector3.forward * velocidadDespzamiento* Time.deltaTime); 
		} 

		if (Input.GetKey(KeyCode.S)) 
		{ 
			this.transform.Translate(Vector3.back * velocidadDespzamiento*Time.deltaTime ); 
		} 

		if (Input.GetKey(KeyCode.A)) 
		{ 
			this.transform.Rotate(new Vector3( 0f , Input.GetAxis( "Horizontal" ) , 0f ) * velocidadDespzamiento*Time.deltaTime*10); 
		} 

		if (Input.GetKey(KeyCode.D)) 
		{ 
			this.transform.Rotate(new Vector3( 0f , Input.GetAxis( "Horizontal" ) , 0f ) * velocidadDespzamiento*Time.deltaTime*10); 
		} 
	 
	}
}
