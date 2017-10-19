using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject _projectile;

    [SerializeField]
    private Transform _Spawnpoint;

    [SerializeField]
    private float _fireRate;

    private float _nextFireTime;

    public void Shoot()
    {
        if (Time.time >= _nextFireTime)
        {
            Instantiate(_projectile, _Spawnpoint.position, _Spawnpoint.rotation);
            _nextFireTime = Time.time + _fireRate;
        }
    }
}
