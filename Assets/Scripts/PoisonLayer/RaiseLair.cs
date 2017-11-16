using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseLair : MonoBehaviour {

	private Rigidbody PoisenLair;
	private Vector3 newPosition;
	private float newYPos;
	private float second;
	public int currentTime;
	private int fivesecond = 0;
	private int maxTime = 40;
	private int minute = 60;
	private bool active;

	void Start(){
		PoisenLair = GetComponent<Rigidbody> ();
		currentTime = maxTime;
	}


	void FixedUpdate () {
		if (active) {
            Debug.Log("moving");
			if (second >= minute) {
				newYPos = 3;
				PoisenLair.velocity = new Vector3(0, newYPos, 0);
				currentTime -= 1;
				second = 0;
			} else {
				second += Time.fixedDeltaTime * 180;
			}/*
			if (currentTime <= 0) {
				active = false;
			}*/
		}
	}

	public void Reset(){
        PoisenLair.velocity = new Vector3(0, 0, 0);
        newYPos = -20;
		PoisenLair.position = new Vector3(0, newYPos, 0);
        currentTime = maxTime;
		active = false;
	}

	public void Move(){
		active = true;
        Debug.Log("start");
	}
}
