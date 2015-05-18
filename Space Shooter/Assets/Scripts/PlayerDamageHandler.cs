using UnityEngine;
using System.Collections;

public class PlayerDamageHandler : MonoBehaviour {



	void OnTriggerEnter2D() {
		health--;
	}
	
	void Update() {
		if (health <= 0) {
			Die();
		}
	}
	
	void Die() {
		Destroy (gameObject);
	}
}
