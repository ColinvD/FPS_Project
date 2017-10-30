using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    
    private InputManager InputManager;
    private int weapon = 1;

    void Start()
    {
        if (!(InputManager = this.GetComponent<InputManager>()))
        {
            InputManager = this.gameObject.AddComponent<InputManager>();
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
            }
        } else if(weapon == 2)
        {
            if (Input.GetMouseButton(0))
            {
                Shooting();
            }
        }
    }

    public void Shooting()
    {
        Ray ray = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction * 50, Color.green);

        if(Physics.Raycast(ray, out hit, 50f) /*&& InputManager.LeftMouseButton()*/)
        {
            //Debug.Log(hit.collider.gameObject.GetComponentInParent<GameObject>().tag);
            if(hit.collider.gameObject.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseLife();
            }
        }
    }
}
