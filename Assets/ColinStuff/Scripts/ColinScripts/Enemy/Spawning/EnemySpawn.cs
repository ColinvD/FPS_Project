using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    [SerializeField]
    private GameObject enemy;
    private GameObject[,] grid;
    private int lengte = 19;
    private int hoogte = 19;
    private float spawnTime = 0.5f;
    private float nextEnemy;

	// Use this for initialization
	void Start () {
        grid = new GameObject[lengte, hoogte];
        for (int i = 0; i < lengte; i++)
        {
            for (int j = 0; j < hoogte; j++)
            {
                grid[i, j] = new GameObject("plek" + i + " , " + j);
                grid[i, j].gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + i * 4, this.gameObject.transform.position.y, this.gameObject.transform.position.z + j * 4);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        int Number1 = Random.Range(0, 19);
        int Number2 = Random.Range(0, 19);
        Vector3 position = new Vector3(grid[Number1, Number2].gameObject.transform.position.x, 1, grid[Number1, Number2].gameObject.transform.position.z);
        if (Time.time > nextEnemy)
        {
            nextEnemy = Time.time + spawnTime;
            Instantiate(enemy, position, this.gameObject.transform.rotation);
        }
	}
}
