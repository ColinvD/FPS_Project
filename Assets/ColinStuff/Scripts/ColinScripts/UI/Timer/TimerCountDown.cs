using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerCountDown : MonoBehaviour {
    
    public int currentTime;
    private int maxTime = 300;
    private int minute = 60;
    private float second;
	// Use this for initialization
	void Start () {
        currentTime = maxTime;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if(second >= minute)
        {
            currentTime -= 1;
            second = 0;
        }
        else
        {
            second += Time.fixedDeltaTime * 60;
        }
        
        if(currentTime <= 0)
        {
            currentTime = maxTime;
            Debug.Log("golf");
        }
    }
}