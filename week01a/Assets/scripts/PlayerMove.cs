using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	bool grounded = false;
	public Rigidbody projectile;

	// Use this for initialization
	void Start () {
	
	}

	
	void Shoot () {
		var bullet = (Rigidbody)Instantiate ( projectile, transform.position + transform.forward * 2f, Quaternion.identity);
		bullet.AddForce ( transform.forward * 1000f );
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey(KeyCode.W)) {
			GetComponent<Rigidbody>().AddForce (transform.forward * 15f);
		}

		transform.Rotate ( 0f, Input.GetAxis ("Horizontal") * Time.deltaTime * 90f, 0f);
		//GetComponent<Rigidbody>().AddForce (transform.right * Input.GetAxis("Horizontal") * 25f);

		if (Input.GetKey (KeyCode.Space) && grounded) {
			GetComponent<Rigidbody>().AddForce (transform.up * 50f);
		}

		if (Physics.Raycast ( transform.position, -Vector3.up, 1.5f) ) {
			grounded = true;
		} else {
			grounded = false;
		}

		if (Input.GetKeyDown(KeyCode.LeftControl)) {
			Shoot ();
		}

	}
}
