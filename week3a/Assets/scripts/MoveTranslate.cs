using UnityEngine;
using System.Collections;

public class MoveTranslate : MonoBehaviour {
	public float speed = 5f;
	public float turnSpeed = 90f;

	// Update is called once per frame
	void Update () {
		// "GetAxis" returns a float from -1 to 1
		// from a "virtual joystick"...
		float x = Input.GetAxis ("Horizontal"); // imagine [A] = -1, [D] = +1
		float y = Input.GetAxis ("Vertical"); // imagine [W] = +1, [S] = -1

		transform.Translate (0f, 0f, y * speed * Time.deltaTime );
		transform.Rotate ( 0f, x * turnSpeed * Time.deltaTime, 0f );
	
	}
}
