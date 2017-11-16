using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerCountDown : MonoBehaviour {

    private VariableData data;
    public int currentTime;
    private int maxTime;
    private int minute = 60;
    private float second;
	// Use this for initialization
	void Start () {
        data = FindObjectOfType<VariableData>();
        maxTime = data.GetMaxTimeDuration();
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
    }
}