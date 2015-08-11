using UnityEngine;
using System.Collections;

public class BallSwap : MonoBehaviour {

	public Transform sphere1, sphere2; // assign in Inspector

	// Use this for initialization
	void Start () {
		StartCoroutine ( BallSwapCoroutine() );
	}

	// a coroutine is a function where we can control how fast it runs
	IEnumerator BallSwapCoroutine () {
		Debug.Log ("started coroutine!");
		yield return 0; // tell Unity to wait for 1 frame, then keep going
		Debug.Log ("ok I waited for 1 frame");
		yield return 0; // wait 1 frame
		yield return 0; // wait 1 frame
		Debug.Log ("ok I waited for 2 more frames... ok....");
		yield return new WaitForSeconds( 1f ); // wait 1 second
		Debug.Log ("I waited for 1 second... I'm always waiting... why???");

		while ( true ) {
			float t = 0f; // number from 0 to 1, 0% to 100%
			Vector3 sphere1start = sphere1.position;
			Vector3 sphere2start = sphere2.position;
			bool didIPlayASoundAlready = false;
			while ( t < 1f ) { // as long as t < 1, do all this stuff, constantly
				t += Time.deltaTime;
				if ( t >= 0.5f && !didIPlayASoundAlready ) { // if we have swapped 50% of the way, play impact sound
					GetComponent<AudioSource>().Play ();
					didIPlayASoundAlready = true;
					StartCoroutine ( ShakeItCoroutine() );
				}
				sphere1.position = Vector3.Lerp ( sphere1start, sphere2start, t );
				sphere2.position = Vector3.Lerp ( sphere2start, sphere1start, t );
				yield return 0;
			}
		}
	}

	IEnumerator ShakeItCoroutine () {
		float t = 1f;
		Vector3 cameraStart = Camera.main.transform.position;
		while ( t > 0f ) { // as long as t > 0, keep shaking the screen
			t -= Time.deltaTime / 0.5f; // it'll now last 0.5 seconds
			Camera.main.transform.position =  cameraStart
											  + Camera.main.transform.right * Mathf.Sin ( Time.time * 20f ) * t
											  + Camera.main.transform.up * Mathf.Sin ( Time.time * 23f ) * t;
			yield return 0;
		}
	}

}







