using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    [SerializeField]
    private GameObject Enemy;
    private GameObject[,] Grid;
    private int Lengte = 15;
    private int Hoogte = 15;
    private float SpawnTime = 0.5f;
    private float NextEnemy;

	// Use this for initialization
	void Start () {
        Grid = new GameObject[Lengte, Hoogte];
        for (int i = 0; i < Lengte; i++)
        {
            for (int j = 0; j < Hoogte; j++)
            {
                Grid[i, j] = new GameObject("plek" + i + " , " + j);
                Grid[i, j].gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + i * 4, this.gameObject.transform.position.y, this.gameObject.transform.position.z + j * 4);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        int Number1 = Random.Range(0, 15);
        int Number2 = Random.Range(0, 15);
        Vector3 position = new Vector3(Grid[Number1, Number2].gameObject.transform.position.x, 1, Grid[Number1, Number2].gameObject.transform.position.z);
        if (Time.time > NextEnemy)
        {
            NextEnemy = Time.time + SpawnTime;
            Instantiate(Enemy, position, this.gameObject.transform.rotation);
        }
	}
}
