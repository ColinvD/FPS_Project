using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    private Transform playerTransform;
    private VariableData data;

    // Use this for initialization
    void Start () {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        data = FindObjectOfType<VariableData>();
    }
	
	// Update is called once per frame
	void Update () {
        if (!playerTransform)
        {
            if (GameObject.FindGameObjectWithTag("Player"))
            {
                playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
            }
        }
        Vector3 movement = new Vector3();
        this.gameObject.transform.LookAt(playerTransform);
        gameObject.transform.rotation = new Quaternion(0, this.gameObject.transform.rotation.y, 0, this.gameObject.transform.rotation.w);
        movement = this.transform.forward;
        this.transform.position += (movement * data.GetEnemySpeed() * Time.deltaTime);
    }
}
