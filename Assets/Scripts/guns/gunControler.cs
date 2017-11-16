using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunControler : MonoBehaviour {
    bool FirstGun = true;
    bool SecondGun = false;
    bool thirdGUn = false;
    public bigGun BFG;
	// Use this for initialization
	void Start () {
        BFG = GetComponent<bigGun>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            
           

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            BFG.enabled = !BFG.enabled;

        }


    }
}
