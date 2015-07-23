using UnityEngine;
using System.Collections;

// "SINGLETON"
// "game manager" / "logic controller"
// and there's only ONE

public class GameLogic : MonoBehaviour {

	// "static" means it lives in the code memory itself
	// "static" means it does NOT live on a GameObject
	// this can ONLY be one copy
	public static GameLogic instance;

	public int currentScore = 0;

	// Use this for initialization
	void Start () {
		currentScore = 0;
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
