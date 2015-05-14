using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	float maxSpeed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Input.GetAxis ("Horizontal");

		transform.Translate( new Vector3(Input.GetAxis ("Horizontal") * maxSpeed * Time.deltaTime, 0, 0));

	}
}
