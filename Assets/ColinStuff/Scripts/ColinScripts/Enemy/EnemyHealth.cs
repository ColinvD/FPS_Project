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
        {
            currentKills.AddKills();
            Destroy(this.gameObject);
        }
	}

    public void LoseLife (int amount)
    {
        lives -= amount;
    }
}
