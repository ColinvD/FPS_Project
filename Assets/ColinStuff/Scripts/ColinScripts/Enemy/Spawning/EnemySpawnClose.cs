using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnClose : MonoBehaviour {

    [SerializeField]
    private GameObject enemy;
    private float spawnTime = 0.5f;
    private float nextEnemy;
    private Transform playerPosition;
    private GameObject[] enemySpawn;
    public List<Transform> enemySpawnTransform;
    private Transform closest;

    // Use this for initialization
    void Start () {
        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        enemySpawn = GameObject.FindGameObjectsWithTag("SpawnPoints");
        for(int i = 0; i < enemySpawn.Length; i++)
        {
            enemySpawnTransform.Add(enemySpawn[i].GetComponent<Transform>());
        }
	}
	
	// Update is called once per frame
	void Update () {
        //playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
        
        if (Time.time > nextEnemy)
        {
            closest = GetClosestSpawnpointToPlayer();
            nextEnemy = Time.time + spawnTime;
            Instantiate(enemy, closest.position, closest.rotation);
        }
    }

    Transform GetClosestSpawnpointToPlayer()
    {
        Transform closestPoint = null;
        float smallestDistance = float.MaxValue;

        for (int i = 0; i < enemySpawnTransform.Count; i++)
        {/*
            if (closestPoint == null)
            {
                closestPoint = enemySpawnTransform[i];
            }
            else if (enemySpawnTransform[i].position.x - playerPosition.position.x < closest.position.x - playerPosition.position.x)
            {

                Debug.Log(enemySpawnTransform[i].position.x - playerPosition.position.x);
                Debug.Log(closest.position.x - playerPosition.position.x);
                if (enemySpawnTransform[i].position.z - playerPosition.position.z < closest.position.z - playerPosition.position.z)
                {
                    closest = enemySpawnTransform[i];
                    Debug.Log(enemySpawnTransform[i].position.x - playerPosition.position.x);
                    Debug.Log(closest.position.x - playerPosition.position.x);
                    Debug.Log(enemySpawnTransform[i].position.z - playerPosition.position.z);
                    Debug.Log(closest.position.z - playerPosition.position.z);
                }
            }*/

            if (Vector3.Distance(enemySpawnTransform[i].position, playerPosition.position) < smallestDistance)
            {
                closestPoint = enemySpawnTransform[i];
                smallestDistance = Vector3.Distance(enemySpawnTransform[i].position, playerPosition.position);
            }
        }
        return closestPoint;
    }
}
