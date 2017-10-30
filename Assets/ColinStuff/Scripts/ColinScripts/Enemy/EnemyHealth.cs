using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    [SerializeField]
    private KillsAmount currentKills;
    private int Lives;
	// Use this for initialization
	void Start () {
        Lives = 3;
        currentKills = GameObject.FindGameObjectWithTag("GameManager").GetComponent<KillsAmount>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Lives <= 0)
        {
            currentKills.AddKills();
            Destroy(this.gameObject);
        }
	}

    public void LoseLife ()
    {
        Lives--;
    }
}
