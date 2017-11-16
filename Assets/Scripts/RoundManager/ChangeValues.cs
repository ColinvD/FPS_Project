using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeValues : MonoBehaviour {

    private RaiseLair poison;
    private TimerCountDown timer;
    private Round round;
    public HealthPackPickup healthPack;
    private EnemySpawnClose enemySpawn;
    public EnemyMovement enemyMovement;
    public EnemyHealth enemyHealth;
    public EnemyAttack enemyAttack;

	// Use this for initialization
	void Start () {
        poison = FindObjectOfType<RaiseLair>();
        timer = FindObjectOfType<TimerCountDown>();
        round = FindObjectOfType<Round>();
        enemySpawn = FindObjectOfType<EnemySpawnClose>();
	}
	
	// Update is called once per frame
	void Update () {
		if(timer.currentTime <= 0)
        {
            Debug.Log("Time is up");
            poison.Move();
            timer.currentTime = 0;
        }
        if(poison.currentTime <= 0)
        {
            poison.Reset();
            timer.currentTime = 300;
            round.AddRound();
        }
	}
}
