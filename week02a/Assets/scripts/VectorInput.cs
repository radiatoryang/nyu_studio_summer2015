using UnityEngine;
using System.Collections;

public class VectorInput : MonoBehaviour {

	// a "public" var is "EXPOSED" to the inspector
	public float speed = 0f;

	public float shiftSpeed = 10f;

	// Update is called once per frame
	void Update () {
		//GetComponent<Transform>().position += new Vector3( 0f, 0f, 1f );

		// this code is FRAMERATE DEPENDENT
		// = behavior will be different based on your framerate
		// transform.position += new Vector3( 0f, 0f, 1f );

		float actualSpeed = 0f;
		if ( Input.GetKey ( KeyCode.LeftShift) ) {
			actualSpeed = shiftSpeed;
		} else {
			actualSpeed = speed;
		}

		// FRAMERATE INDEPENDENT, multiply by Time.deltaTime
		// Time.deltaTime = "fraction of a second in between a frame"
		// 60 FPS >> Time.deltaTime = ~16 ms
		// 10 FPS >> Time.deltaTime = ~100 ms
		if ( Input.GetKey (KeyCode.W) ) {
			transform.position += Vector3.forward * Time.deltaTime * actualSpeed;
		}

		if ( Input.GetKey (KeyCode.A) ) {
			transform.position += new Vector3( -1f, 0f, 0f ) * Time.deltaTime * actualSpeed;
		}

		if ( Input.GetKey (KeyCode.S) ) {
			transform.position += -Vector3.forward * Time.deltaTime * actualSpeed;
		}

		if ( Input.GetKey (KeyCode.D) ) {
			transform.position += new Vector3( 1f, 0f, 0f ) * Time.deltaTime * actualSpeed;
		}
	}
}


