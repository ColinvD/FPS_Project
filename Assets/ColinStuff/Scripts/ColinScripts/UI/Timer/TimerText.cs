using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerText : MonoBehaviour {

    [SerializeField]
    private Text timeText;
    private TimerCountDown countdown;

    // Use this for initialization
    void Start () {
        countdown = GetComponent<TimerCountDown>();
        timeText.text = "Time: " + countdown.currentTime;
    }
	
	// Update is called once per frame
	void Update () {
        int minutes = countdown.currentTime / 60;
        int seconds = countdown.currentTime - minutes * 60;


        timeText.text =  minutes + ":" + seconds;
    }
}
