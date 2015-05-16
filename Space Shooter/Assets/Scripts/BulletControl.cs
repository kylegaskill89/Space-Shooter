using UnityEngine;
using System.Collections;

public class BulletControl : MonoBehaviour {


	// Update is called once per frame
	void Update () {

		// Calls the BulletStats script
		
		BulletStats stats = GetComponent<BulletStats>();


		transform.Translate( new Vector3(0, stats.maxSpeed * Time.deltaTime, 0));


		// This part of the code handles screen boundaries
		
		Vector3 pos = transform.position;
		
		if (pos.y > Camera.main.orthographicSize) {
			stats.currentBulletHP = 0;
		}

		if (stats.currentBulletHP <= 0) {
			Destroy(this.gameObject);
		}
	}
}
