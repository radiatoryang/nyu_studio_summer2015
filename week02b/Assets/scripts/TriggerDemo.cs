using UnityEngine;
using System.Collections;

public class TriggerDemo : MonoBehaviour {

	bool didITriggerYet = false;

	// whenever an object with a rigidbody and a collider
	// enters the trigger, the code here will execute
	void OnTriggerEnter () {
		didITriggerYet = true;
	}
	
	// Update is called once per frame
	void Update () {
		if ( didITriggerYet == true ) {
			transform.Rotate ( 0f, 5f, 0f ); // if triggered, then spin
		}
	}


}
