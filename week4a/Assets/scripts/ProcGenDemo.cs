using UnityEngine;
using System.Collections;

using System.Collections.Generic; // we're going to add this line so that we can use something called "Lists"

public class ProcGenDemo : MonoBehaviour {

	// to instantiate or "clone", you need an original copy of something
	public Transform prefab; // assign in Inspector
	public List<Transform> listOfClones = new List<Transform>();

	// Use this for initialization
	void Start () {
		// a FOR LOOP is a WHILE LOOP with a built-in control
		// 1st part: initialize a variable, usually a counter
		// 2nd part: the "if" statement to check each time
		// 3rd part: what to do at the end, usually increment counter
		for ( int i=0; i < 200; i++) {
			// "CASTING" is telling Unity that one type of variable is actually another type of variable
			Transform newClone = (Transform)Instantiate ( prefab, Random.insideUnitSphere * 5f, Quaternion.Euler(0f, Random.Range (0f, 360f), 0f) );
			newClone.localScale = new Vector3(Random.Range (0.5f, 1f), 
			                                  Random.Range (0.5f, 2f), 
			                                  Random.Range (0.5f, 1f) 
			                                 );
			listOfClones.Add ( newClone ); // tell Santa to add this cloned child to their list
			Debug.Log( i.ToString() );
		}
	}
	
	// Update is called once per frame
	void Update () {
		// simplest reset is this: tell Unity to reload the current level
		if ( Input.GetKeyDown (KeyCode.R) ) {
			Application.LoadLevel ( Application.loadedLevel );
		}

		// control all the clones
		if ( Input.GetKeyDown (KeyCode.Space) ) {
//			for ( int i=0; i<200; i++) {
//				listOfClones[i].localScale *= 2f; // double in size
//			}
			foreach ( Transform clone in listOfClones ) {
				clone.localScale *= 2f;
			}
		}
	}

}





