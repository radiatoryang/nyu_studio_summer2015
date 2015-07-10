using UnityEngine;
using System.Collections;
using UnityEngine.UI; // we need this line to use UI objects

public class Stopwatch : MonoBehaviour {

	public Text myTextObject; // assign in inspector
	float timeElapsed = 0f;

	// Update is called once per frame
	void Update () {
		// if I am holding down spacebar, progress the time elapsed
		if ( Input.GetKey (KeyCode.Space) ) {
			timeElapsed += Time.deltaTime;
		}

		// display current time elapsed; convert number to a string
		myTextObject.text = "TRY TO LAND EXACTLY ON #10\n" + timeElapsed.ToString();
	}
}






