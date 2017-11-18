using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    [SerializeField]
    private KillsAmount currentKills;
    private VariableData data;
    private int lives;
	// Use this for initialization
	void Start () {
        
        currentKills = GameObject.FindGameObjectWithTag("GameManager").GetComponent<KillsAmount>();
        data = FindObjectOfType<VariableData>();
        lives = data.GetEnemyHealth();
    }

    void Update()
    {
        if(this.transform.position.y < -10)
        {
            Destroy(this.gameObject);
        }
    }

    public void LoseLife(int amount, string byWhat)
    {
        lives -= amount;
        if (lives <= 0 && byWhat == "Poison")
        {
            Destroy(this.gameObject);
        }
        else if (lives <= 0 && byWhat == "Player")
        {
            currentKills.AddKills();
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            lives = 0;
        }
    }
}
