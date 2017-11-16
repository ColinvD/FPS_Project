using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ChangeValues : MonoBehaviour {

    private RaiseLair poison;
    private TimerCountDown timer;
    private Round round;
    private VariableData data;
    private int randomNumber;
	// Use this for initialization
	void Start () {
        poison = FindObjectOfType<RaiseLair>();
        timer = FindObjectOfType<TimerCountDown>();
        round = FindObjectOfType<Round>();
        data = FindObjectOfType<VariableData>();
	}
	
	// Update is called once per frame
	void Update () {
        if (timer.currentTime <= 0)
        {
            Debug.Log("Time is up");
            poison.Move();
            timer.currentTime = 0;
        }
        if(poison.currentTime <= 0)
        {
            randomNumber = Random.Range(0, 8);
            poison.Reset();
            switch (randomNumber)
            {
                case 0: data.ChangeEnemyLimit();
                        EditorUtility.DisplayDialog("There is a change!!!", "You're on to the next round and there can be more enemies on the map", "Ok");
                        break;
                case 1: data.ChangeEnemySpeed();
                        EditorUtility.DisplayDialog("There is a change!!!", "You're on to the next round and the enemies are faster", "Ok");
                        break;
                case 2: data.ChangeEnemyHealth();
                        EditorUtility.DisplayDialog("There is a change!!!", "You're on to the next round and the enemies have more health", "Ok");
                        break;
                case 3: data.ChangeEnemyDamage();
                        EditorUtility.DisplayDialog("There is a change!!!", "You're on to the next round and enemies do more damage", "Ok");
                        break;
                case 4: data.ChangeMaxTimeDuration();
                        EditorUtility.DisplayDialog("There is a change!!!", "You're on to the next round and you have less time to get lots of kills", "Ok");
                        break;
                case 5: data.ChangeDeurToll();
                        EditorUtility.DisplayDialog("There is a change!!!", "You're on to the next round and you need more coins to go through the door", "Ok");
                        break;
                case 6: data.ChangeHealthContainer();
                        EditorUtility.DisplayDialog("There is a change!!!", "You're on to the next round and you can earn less health from the healthpacks", "Ok");
                        break;
                case 7: data.ChangeAmmoContainer();
                        EditorUtility.DisplayDialog("There is a change!!!", "You're on to the next round and you can earn more ammo from the ammopacks", "Ok");
                        break;
            }
            timer.currentTime = data.GetMaxTimeDuration();
            round.AddRound();
        }
	}
}
