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
    private VariableData data;

    // Use this for initialization
    void Start () {
        data = FindObjectOfType<VariableData>();
        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        enemySpawn = GameObject.FindGameObjectsWithTag("SpawnPoints");
        for(int i = 0; i < enemySpawn.Length; i++)
        {
            enemySpawnTransform.Add(enemySpawn[i].GetComponent<Transform>());
        }
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Time.time > nextEnemy && GameObject.FindGameObjectsWithTag("Enemy").Length < data.GetEnemyLimit())
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
        {
            if (Vector3.Distance(enemySpawnTransform[i].position, playerPosition.position) < smallestDistance)
            {
                closestPoint = enemySpawnTransform[i];
                smallestDistance = Vector3.Distance(enemySpawnTransform[i].position, playerPosition.position);
            }
        }
        return closestPoint;
    }
}
