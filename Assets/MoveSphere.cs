using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour {

	// Use this for initialization
	public float velocidadDespzamiento = 2f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.UpArrow)) 
		{ 
			this.transform.Translate(Vector3.forward * velocidadDespzamiento* Time.deltaTime); 
		} 

		if (Input.GetKey(KeyCode.DownArrow)) 
		{ 
			this.transform.Translate(Vector3.back * velocidadDespzamiento*Time.deltaTime ); 
		} 

		if (Input.GetKey(KeyCode.LeftArrow)) 
		{ 
			this.transform.Translate(Vector3.left * velocidadDespzamiento*Time.deltaTime );
            this.transform.Rotate(new Vector3(0f, Input.GetAxis("Horizontal"), 0f) * velocidadDespzamiento * Time.deltaTime * 10);
        } 

		if (Input.GetKey(KeyCode.RightArrow)) 
		{ 
			this.transform.Translate(Vector3.right * velocidadDespzamiento*Time.deltaTime );
            this.transform.Rotate(new Vector3(0f, Input.GetAxis("Horizontal"), 0f) * velocidadDespzamiento * Time.deltaTime * 10);
        } 

	}
}
