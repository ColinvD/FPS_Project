using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoAmount : MonoBehaviour {

    [SerializeField]
    private Text AmmoText;
    private int Ammo = 5;

    // Use this for initialization
    void Start () {
        AmmoText.text = "Ammo: " + Ammo;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
