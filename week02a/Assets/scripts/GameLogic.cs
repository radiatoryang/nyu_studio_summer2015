using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameLogic : MonoBehaviour {

	public Transform player, sphere; // assign these in the Inspector
	public Text victoryText; // assign this in the Inspector

	bool hasSphere = false;
	
	void Update () {
		// if player presses space AND distance b/w player-sphere < 15
		if (Input.GetKeyDown (KeyCode.Space) && 
		    Vector3.Distance ( player.position, sphere.position ) < 15f ) 
		{
				hasSphere = true;
				victoryText.text = "YOU WIN!"; // victory text!
		}


		if (hasSphere) {
			Debug.Log ("YOU ARE GREAT");
		}
	}

}
