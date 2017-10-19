using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// krijgt input van het spel
public class playerInput : MonoBehaviour
{
    
    private PlayerShoot _PlayerShoot;

    float xInput;

    void Awake()
    {
        _PlayerShoot = GetComponent<PlayerShoot>();
    }



    void Update()
    {
       
        if (Input.GetMouseButton(0))
        {
            _PlayerShoot.Shoot();
        }
        
    }

    
}
