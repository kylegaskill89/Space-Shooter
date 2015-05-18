using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// Grabs EnemyStats script

		EnemyStats EnemyStats = GetComponent<EnemyStats>();
		//BulletStats stats = GetComponent<BulletStats>();


		// Debug controls

		if (Input.GetKeyDown(KeyCode.Delete)) {
			EnemyStats.currentEnemyHP = -1;
			Debug.Log ("Enemy Destroyed!");
		}

		if (EnemyStats.currentEnemyHP <= 0) {
			Destroy (this.gameObject);
		}


	}


	}

