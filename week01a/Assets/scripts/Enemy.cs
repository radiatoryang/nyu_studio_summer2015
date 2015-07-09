using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public Rigidbody projectile;
	float timer;

	// Use this for initialization
	void Start () {
		InvokeRepeating ( "Shoot", 0f, 3f);
	}

	void Shoot () {
		var bullet = (Rigidbody)Instantiate ( projectile, transform.position, Quaternion.identity);
		bullet.AddForce ( (Camera.main.transform.position - transform.position) * 100f );
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > 2.5f ) {
			transform.localScale = Vector3.one * 5f;
		}

		if (timer > 3f ) {
			transform.localScale = Vector3.one * 10f;
			timer = 0f;
		}
	}
}
