using UnityEngine;
using System.Collections;

public class GridInstantiate : MonoBehaviour {

	public Transform floorTilePrefab, wallTilePrefab, pathPrefab;

	// Use this for initialization
	void Start () {
		for ( int x = 0; x < 5; x++ ) {
			for ( int z = 0; z < 5; z++ ) {
				Vector3 pos = new Vector3( x * 5, 0, z * 5) + transform.position;
				float randomNumber = Random.value; // same as Random.Range(0f, 1f)
				if ( randomNumber < 0.7f ) { // 70%
					Transform newClone = (Transform)Instantiate ( floorTilePrefab, pos, Quaternion.identity);
					newClone.GetComponent<Renderer>().material.color = new Color( Random.value, Random.value, Random.value, 1f );
				} else if ( randomNumber < 0.95f ) { // 25%
					//Instantiate ( pathPrefab, pos, Quaternion.identity);
				} else { // 5%
					Debug.Log ("I did nothing!");
					Instantiate ( pathPrefab, pos, Quaternion.Euler ( 0f, Random.Range (0,4) * 90f, 0f )  );
				}
			}
		}
		// after a FOR LOOP is OVER, the code keeps going
		Destroy ( this.gameObject );
	}

}
