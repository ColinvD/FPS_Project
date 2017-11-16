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
<<<<<<< HEAD

    public void LoseLife (int amount, string byWhat)
    {
        lives -= amount;
        if(lives <= 0 && byWhat == "Poison")
        {
            Destroy(this.gameObject);
        } else if (lives <= 0 && byWhat == "Player")
=======
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            lives = 0;
        }
    }
    // Update is called once per frame
    void Update () {
		if (lives <= 0)
>>>>>>> e6b99b58eaa6a276b37862821b71a7f90d55bb5c
        {
            currentKills.AddKills();
            Destroy(this.gameObject);
        }
    }
}
