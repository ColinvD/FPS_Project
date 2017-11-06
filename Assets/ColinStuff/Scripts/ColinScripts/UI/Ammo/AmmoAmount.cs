using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoAmount : MonoBehaviour {

    [SerializeField]
    private Text ammoText;
    private int ammo = 5;

    // Use this for initialization
    void Start () {
        ammoText.text = "Ammo: " + ammo;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
