using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerCountDown : MonoBehaviour {
    
    public int currentTime;
    private int maxTime = 300;
    private int minute = 60;
    private float second;
    private int secondsPast = 0;
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
            secondsPast++;
        }
        else
        {
            second += Time.fixedDeltaTime * 60;
            secondsPast++;
        }
        
        if(currentTime <= 0)
        {
            currentTime = maxTime;
            Debug.Log("golf");
        }
    }

    public int GetSecondsPast()
    {
        return secondsPast;
    }
}