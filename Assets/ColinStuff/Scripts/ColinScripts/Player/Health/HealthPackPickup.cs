using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPackPickup : MonoBehaviour {

    private PlayerHealth lives;

	// Use this for initialization
	void Start () {
        lives = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "HealthPack")
        {
            lives.GainHealth(30f);
            Destroy(other.gameObject);
        }
    }
}
