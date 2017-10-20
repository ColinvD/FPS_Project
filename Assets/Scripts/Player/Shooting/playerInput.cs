using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// krijgt input van het spel
public class playerInput : MonoBehaviour
{
    // [SerializeField]
    //  private Pistol _pistol;
   

    private PlayerShoot _PlayerShoot;

    float xInput;

    void Awake()
    {
        _PlayerShoot = GetComponent<PlayerShoot>();
    }
}



   
