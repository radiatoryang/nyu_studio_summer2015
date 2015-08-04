using UnityEngine;
using System.Collections;

public class DayNight : MonoBehaviour {

	public Light sun;
	public float currentTime = 0f; // value from 0-1, 0 is midnight, 1 is high noon
	public float timeSpeed = 1f;

	public Vector3 highNoonRotation, midnightRotation; // assign in Inspector
	public Color highNoonColor, midnightColor;

	// Update is called once per frame
	void Update () {
		// "LERP"
		// LERP = "linear interpolation" >> "blending between 2 values"
		sun.transform.rotation = Quaternion.Slerp ( Quaternion.Euler ( midnightRotation ),
		                                            Quaternion.Euler ( highNoonRotation ),
		                                            currentTime 
		                                          );

		sun.color = Color.Lerp ( midnightColor, highNoonColor, currentTime );

		// Mathf.Sin( Time.time * frequency ) * amplitude
		currentTime = Mathf.Abs ( Mathf.Sin ( Time.time * timeSpeed ) );
	}

	// UI FUNCTIONS MUST BE PUBLIC
	// we're going to have our Slider UI automatically fill in "timeOfDay" with current value
	public void ChangeTimeOfDay( float newTimeOfDay ) {
		currentTime = newTimeOfDay;
	}

	public void ChangeSpeedOfDay( float newSpeedOfDay ) {
		timeSpeed = newSpeedOfDay;
	}


}





