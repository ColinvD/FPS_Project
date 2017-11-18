using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunControler : MonoBehaviour {
    bool FirstGun = true;
    bool SecondGun = false;
    bool ThirdGun = false;
    public bigGun BFG;
    public LaserGun Lazers;
    public Shoot Pistol;
	// Use this for initialization
	void Start () {
        BFG = GetComponent<bigGun>();
        Lazers = GetComponent<LaserGun>();
        Pistol = GetComponent<Shoot>();
	}
	
	// Update is called once per frame
	void Update () {
        if (FirstGun == true)
        {
            
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                BFG.enabled = !BFG.enabled;
                Lazers.enabled = !Lazers.enabled;
                FirstGun = false;
                SecondGun = true;
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                BFG.enabled = !BFG.enabled;
                Pistol.enabled = !Pistol.enabled;
                FirstGun = false;
                ThirdGun = true;
            }
        }
        if(SecondGun == true)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                BFG.enabled = !BFG.enabled;
                Lazers.enabled = !Lazers.enabled;
                FirstGun = true;
                SecondGun = false;
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Pistol.enabled = !Pistol.enabled;
                Lazers.enabled = !Lazers.enabled;
                SecondGun = false;
                ThirdGun = true;
            }
        }
        if(ThirdGun == true)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                BFG.enabled = !BFG.enabled;
                Pistol.enabled = !Pistol.enabled;
                FirstGun = true;
                ThirdGun = false;
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Pistol.enabled = !Pistol.enabled;
                Lazers.enabled = !Lazers.enabled;
                SecondGun = true;
                ThirdGun = false;
            }
        }


    }
}
