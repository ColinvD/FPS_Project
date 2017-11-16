using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    [SerializeField]
    private int _BulletsInClip;
    [SerializeField]
    private int _clipSize;
    // Use this for initialization
    public virtual void Shoot()
    {
        if (_BulletsInClip > 0)
        {
            _BulletsInClip--;
            print("*bang*");
        }
        else
        {
            print("out of bullets");
        }
    }
    public void Reload()
    {
        _BulletsInClip = _clipSize;
        print("reload");
    }
}
