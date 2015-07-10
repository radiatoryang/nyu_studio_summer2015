using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class HelloWorld : MonoBehaviour {

	// create a VARIABLE to remember where the Text UI object is
	public Text myTextObject;

	// Any code we put in Start will happen ONCE, right at beginning of game
	void Start () {
		Debug.Log ( "Hello World" );
	}
	
	// Code we put in UPDATE happens CONSTANTLY, ALL THE TIME
	void Update () {
		Debug.Log ( "Bonjour Monde" );
		myTextObject.text += "Hola Mundo";

	}
}
