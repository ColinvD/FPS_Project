using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillsAmount : MonoBehaviour {

    [SerializeField]
    private Text KillsText;
    private int Kills = 0;

    // Use this for initialization
    void Start () {
        KillsText.text = "Kills: " + Kills;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddKills ()
    {
        Kills++;
        KillsText.text = "Kills: " + Kills;
    }
}
