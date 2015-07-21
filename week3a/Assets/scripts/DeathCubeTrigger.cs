using UnityEngine;
using System.Collections;

public class DeathCubeTrigger : MonoBehaviour {

	public ParticleSystem fireParticles; // assign in Inspector

	// if the player enters this trigger, delete the player from the game
	void OnTriggerEnter ( Collider activator ) {
		// to delete the whole thing, you must delete the gameobject
		Destroy ( activator.gameObject );

		fireParticles.Play (); // and now the fire will begin

	}
}
