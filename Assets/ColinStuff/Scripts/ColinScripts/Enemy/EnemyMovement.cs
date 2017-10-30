using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    private Transform PlayerTransform;

	// Use this for initialization
	void Start () {
        PlayerTransform = GameObject.FindGameObjectWithTag("Player").transform;

    }
	
	// Update is called once per frame
	void Update () {
        Vector3 movement = new Vector3();
        this.gameObject.transform.LookAt(PlayerTransform);
        movement = this.transform.forward;
        this.transform.position += (movement * 2 * Time.deltaTime);
        //this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * 25);
    }
}
