using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoDrop : MonoBehaviour {

    private PlayerShoot shots;

    void Start()
    {
        shots = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerShoot>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "AmmoPack")
        {
            shots.GainAmmo();    
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
        
    }
}
