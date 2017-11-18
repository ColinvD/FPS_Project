﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBoxSpawn : MonoBehaviour {

    [SerializeField]
    private GameObject AmmoBox;
    [SerializeField]
    private GameObject[] spawnPlace;

    void Start()
    {
        spawnPlace = GameObject.FindGameObjectsWithTag("AmmoPackSpawn");
        StartCoroutine(SpawnAmmoPack());
    }

    IEnumerator SpawnAmmoPack()
    {
        while (true)
        {
            for (int i = 0; i < spawnPlace.Length; i++)
            {
                Destroy(Instantiate(AmmoBox, spawnPlace[i].transform.position, spawnPlace[i].transform.rotation), 4.5f);
            }
            yield return new WaitForSeconds(5);
        }
        
    }
}
