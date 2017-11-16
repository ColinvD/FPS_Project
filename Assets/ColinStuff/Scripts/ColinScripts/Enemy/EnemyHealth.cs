using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    [SerializeField]
    private KillsAmount currentKills;
    private int lives;
	// Use this for initialization
	void Start () {
        lives = 3;
        currentKills = GameObject.FindGameObjectWithTag("GameManager").GetComponent<KillsAmount>();
	}

    public void LoseLife (int amount, string byWhat)
    {
        lives -= amount;
        if(lives <= 0 && byWhat == "Poison")
        {
            Destroy(this.gameObject);
        } else if (lives <= 0 && byWhat == "Player")
        {
            currentKills.AddKills();
            Destroy(this.gameObject);
        }
    }
}
