using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		EnemyStats stats = GetComponent<EnemyStats>();

		transform.Translate( new Vector3( 0, (stats.maxSpeed * -1) * Time.deltaTime, 0));

	}
}
