using UnityEngine;
using System.Collections;

public class PathInstantiate : MonoBehaviour {

	int counter = 0;
	public Transform floorPrefab, gridPrefab;

	int counterMax = 50;

	void Start () {
		counterMax = Random.Range (10, 20); // generate a random number from 10-50 (it will NEVER be 51)
	}

	// Update is called once per frame
	void Update () {
		if (counter < counterMax ) {
			// randomly turning
			float randomNumber = Random.Range (0f, 1f);
			if ( randomNumber < 0.25f) { // 0-0.25
				transform.Rotate ( 0f, 90f, 0f );
			} else if ( randomNumber < 0.5f) { // 0.25 - 0.5
				transform.Rotate ( 0f, -90f, 0f );
			} else if ( randomNumber > 0.99f ) { // 5% chance
				Instantiate ( gridPrefab, transform.position, Quaternion.identity );
			}

			// instantiation
			Instantiate ( floorPrefab, transform.position, transform.rotation );

			// global space: orientation of the world, West will always West
			// local space: specific to an object, Left will mean "your Left" or "my Left"
			transform.Translate ( 0f, 0f, 5f); // "move 5 units forward in Local Space"
			// transform.position += transform.forward * 5f;
			// transform.position += Vector3.forward; // BAD, NO, THIS IS WORLD SPACE

			counter++;
		} else { // counter >= 50
			Destroy (this.gameObject);
		}
	}
}
