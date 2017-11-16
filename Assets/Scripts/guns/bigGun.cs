using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigGun : MonoBehaviour
{
    [SerializeField]
    private int _BulletsInClip;
    [SerializeField]
    private int _clipSize;
    [SerializeField]
    private GameObject _projectile;

    [SerializeField]
    private Transform _Spawnpoint;

    [SerializeField]
    private float _fireRate;

    public float _nextFireTime;

    void Update()
    {
        if (_BulletsInClip > 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Shoot();

                print("*bang*");
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
    public void Shoot()
    {
        if (Time.time >= _nextFireTime)
        {

            Instantiate(_projectile, _Spawnpoint.position, _Spawnpoint.rotation);
            _nextFireTime = Time.time + _fireRate;
            _BulletsInClip--;
        }
    }

    public void GainAmmo()
    {
        _clipSize++;
    }

}


