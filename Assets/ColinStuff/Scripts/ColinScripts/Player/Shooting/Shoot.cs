using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    private InsertShot insert;
    private InputManager inputManager;
    private string object_hit;
    private Vector3 begPos;
    private Vector3 rot;
    private Vector3 endPos;
    private int weapon = 1;

    void Start()
    {
        if (!(insert = GetComponent<InsertShot>()))
        {
            insert = gameObject.AddComponent<InsertShot>();
        }
        if (!(inputManager = GetComponent<InputManager>()))
        {
            inputManager = gameObject.AddComponent<InputManager>();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weapon = 1;
        } else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            weapon = 2;
        }

        if(weapon == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Shooting();
                StartCoroutine(insert.DoPHP(object_hit, begPos, endPos, rot, 12345));
            }
        } else if(weapon == 2)
        {
            if (Input.GetMouseButton(0))
            {
                Shooting();
                StartCoroutine(insert.DoPHP(object_hit, begPos, endPos, rot, 12345));
            }
        }
    }

    public void Shooting()
    {
        begPos = transform.position;
        Camera maincamera = FindObjectOfType<Camera>();
        Ray ray = new Ray(transform.position, maincamera.transform.forward);
        rot = ray.direction;
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction * 50, Color.green);
        if(Physics.Raycast(ray, out hit, 50f))
        {
            object_hit = hit.collider.gameObject.tag;
            endPos = hit.point;
            if (hit.collider.gameObject.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseLife(1, "Player");
            }
        }
    }
}
