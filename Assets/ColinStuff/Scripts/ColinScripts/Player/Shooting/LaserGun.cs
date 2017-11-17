using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGun : MonoBehaviour
{
    [SerializeField]
    private int _BulletsInClip;
    [SerializeField]
    private int _clipSize;
    
    [SerializeField]
    private Shoot pistol;
    
    
    // Update is called once per frame
    void Update () {
        if (_BulletsInClip > 0)
        {
            if (Input.GetMouseButton(0))
            {
                pistol.Shooting();
                _BulletsInClip--;
            }
        }
        else
        {
            print("out of bullets");
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            _BulletsInClip = _clipSize;
            print("reload");
        }
    }
}
