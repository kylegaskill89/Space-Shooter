using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	float shipBoundary = .42f;
	float maxSpeed = 10f;
	float attackTimer = 0f;
	float attackSpeed = .5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		// This is where the horizontal movement is taken care of

		Input.GetAxis ("Horizontal");

		transform.Translate( new Vector3(Input.GetAxis ("Horizontal") * maxSpeed * Time.deltaTime, 0, 0));


		// This part of the code handles screen boundaries

		Vector3 pos = transform.position;
		

		// Get the size of the camera so that the boundary can be set

		float screenRatio = (float)Screen.width / (float)Screen.height;
		float orthoSize = Camera.main.orthographicSize * screenRatio;

		// Asks the application if the ship is leaving the camera view

		if (pos.x + shipBoundary > orthoSize) {
			pos.x = orthoSize - shipBoundary;
		}
		if (pos.x - shipBoundary < -orthoSize) {
			pos.x = -orthoSize + shipBoundary;
		}

		// If the ship is leaving the camera, then this puts it back at the edge

		transform.position = pos;

		// Timer increases between attacks

		attackTimer += .5f * Time.deltaTime;
		Debug.Log (attackTimer);

		// If the time since the last shot is higher than the attack speed and the player is pressing the button to shoot, then the timer is reset and the shot is fired

		if (attackTimer >= attackSpeed && Input.GetAxis("Fire1") != 0) {
			Debug.Log("Fire");
			attackTimer = 0;	
	}
	}
}
