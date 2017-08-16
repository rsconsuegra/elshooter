using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    GameObject prefab;
	// Use this for initialization
	void Start () {
        prefab = Resources.Load ("Bullet") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.F))
        {
            GameObject projectile = Instantiate(prefab) as GameObject;
            projectile.transform.position = transform.position + this.transform.forward*2;

            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = this.transform.forward * 40;
            Object.Destroy(projectile, 2.0f);
        }

        
	}
}
