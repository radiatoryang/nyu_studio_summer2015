using UnityEngine;
using System.Collections;

using UnityEngine.UI; // we need that line to talk to Text

public class TenPrintPort : MonoBehaviour {

	public Text myText; // assign in Inspector

	// Use this for initialization
	void Start () {
		// set the random seed, what page of that awesome book that Unity will start reading from
		Random.seed = 420;

		// WHILE loop: it will check the if() statement
		// inside of it; if true, it will do everything
		// inside its scope; if false, it will keep going

		// an "infinite loop" is an UNBOUNDED LOOP
		// a BOUNDED LOOP ends eventually
		int counter = 0;
		while ( counter < 1000 ) {
			myText.text += Random.Range (0f, 100f) > 50f ? "/" : "\\" ;		
			counter++;
			//Debug.Log ( counter.ToString () );
		}
	}

	void Update () {
		// simplest reset is this: tell Unity to reload the current level
		if ( Input.GetKeyDown (KeyCode.R) ) {
			Application.LoadLevel ( Application.loadedLevel );
		}
	}

}
