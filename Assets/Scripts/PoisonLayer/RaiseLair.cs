using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseLair : MonoBehaviour {

	private Transform PoisenLair;
	private Vector3 newPosition;
	private float newYPos;
	private float second;
	private int currentTime;
	private int fivesecond = 0;
	private int maxTime = 40;
	private int minute = 60;
	private bool active;

	void Start(){
		PoisenLair = GetComponent<Transform> ();
		currentTime = maxTime;

	}


	void FixedUpdate () {
		if (Input.GetKeyDown (KeyCode.H)) {
			Debug.Log ("hallo");
			Move ();
		}
		if (active) {
			if (second >= minute) {
				newYPos = PoisenLair.position.y + 1;
				newPosition = new Vector3 (0, newYPos, 0);
				PoisenLair.position = newPosition;
				currentTime -= 1;
				second = 0;
			} else {
				second += Time.fixedDeltaTime * 180;
			}
			Debug.Log (currentTime);
			if (currentTime <= 0) {
				active = false;
			}
		}
	}

	void Reset(){
		newYPos = -20;
		newPosition = new Vector3 (0, newYPos, 0);
		PoisenLair.position = newPosition;
		active = false;
	}

	void Move(){
		Debug.Log ("balletjes");
		active = true;
	}
}
