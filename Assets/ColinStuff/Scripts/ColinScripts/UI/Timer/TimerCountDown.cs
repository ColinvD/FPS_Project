using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountDown : MonoBehaviour {

    [SerializeField]
    private Text TimeText;
    private int CurrentTime;
    private int MaxTime = 300;
    private int minute = 60;
    private float second;
	// Use this for initialization
	void Start () {
        CurrentTime = MaxTime;
        TimeText.text = "Time: " + CurrentTime;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if(second >= minute)
        {
            CurrentTime -= 1;
            second = 0;
        }
        else
        {
            second += Time.fixedDeltaTime * 60;
        }
        
        if(CurrentTime <= 0)
        {
            CurrentTime = MaxTime;
            Debug.Log("golf");
        }
        TimeText.text = "Time: " + CurrentTime;
    }
}


/*
 * text aanpassen in ander script
 */