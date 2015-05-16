using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour {
	
	public float maxPlayerHP = 10f;
	public float currentPlayerHP = 10f;
	public float percentHP = 1f;

	public float attackSpeed = .5f;

	public float maxSpeed = 25f;
	

	void Start () {
	
	}

	void Update () {

		// Converts current health into a percentage so that it can be plugged into the health bar fill value

		percentHP = (currentPlayerHP / maxPlayerHP);


		// Debug HP control

		if (Input.GetKey (KeyCode.KeypadMinus)) {
			currentPlayerHP -= Time.deltaTime;
		}	

	}

}