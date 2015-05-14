using UnityEngine;
using System.Collections;

public class ScreenBoundaries : MonoBehaviour {

	public float shipBoundary = .3f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 pos = transform.position;


		float screenRatio = (float)Screen.width / (float)Screen.height;
		float orthoSize = Camera.main.orthographicSize * screenRatio;

		if (pos.x + shipBoundary > orthoSize) {
			pos.x = orthoSize - shipBoundary;
		}
		if (pos.x - shipBoundary < -orthoSize) {
			pos.x = -orthoSize + shipBoundary;
		}
		transform.position = pos;
	}
}
