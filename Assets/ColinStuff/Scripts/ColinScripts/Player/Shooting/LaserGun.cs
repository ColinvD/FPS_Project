using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGun : MonoBehaviour {
    [SerializeField]
    private Shoot pistol;
    
    
    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButton(0))
        {
            pistol.Shooting();
        }
    }
}
