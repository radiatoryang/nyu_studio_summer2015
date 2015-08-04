using UnityEngine;
using System.Collections;

// move my sphere where I clicked
public class CursorRaycast : MonoBehaviour {

	public Transform sphere; // assign in Inspector
	Vector3 destination;

	void Update () {
		Ray ray = Camera.main.ScreenPointToRay ( Input.mousePosition );

		// RaycastHit will tell me where and what it hit, not just T / F
		RaycastHit rayHit = new RaycastHit();
		Debug.DrawRay ( ray.origin, ray.direction * 1000f, Color.yellow );

		// actually shoot raycast
		if ( Physics.Raycast ( ray, out rayHit, 1000f ) && Input.GetMouseButtonDown (0)  ) {
			destination = rayHit.point; // rayHit.point = where it hit
		}

		// smoothly move the sphere 10% of the way
		sphere.position = Vector3.Lerp ( sphere.position, destination, 5f * Time.deltaTime);
		// sphere.position += Vector3.Normalize ( destination - sphere.position ) * Time.deltaTime * 100f;
	}
}
