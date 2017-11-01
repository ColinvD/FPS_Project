using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesAmount : MonoBehaviour {

    [SerializeField]
    private Text LivesText;
    private PlayerHealth live;

    // Use this for initialization
    void Start () {
        live = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
	}
	
	// Update is called once per frame
	void Update () {
        LivesText.text = "Lives: " + live.health;
    }
}