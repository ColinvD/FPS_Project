using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private int _BulletsInClip;
    [SerializeField]
    private int _clipSize;
   
    private InputManager inputManager;
   // private int weapon = 1;

    void Start()
    {
        if (!(inputManager = GetComponent<InputManager>()))
        {
            inputManager = gameObject.AddComponent<InputManager>();
        }
    }

    void Update()
    {
        if (_BulletsInClip > 0)
        {
            if (Input.GetMouseButton(0))
            {
                Shooting();
                _BulletsInClip--;
            }
        }
        else
        {
            print("out of bullets");
        }
            
            if (Input.GetKeyDown(KeyCode.R))
            {
                _BulletsInClip = _clipSize;
                print("reload");
            }



        }

    public void Shooting()
    {
        Camera maincamera = FindObjectOfType<Camera>();
        Ray ray = new Ray(transform.position, maincamera.transform.forward);
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction * 50, Color.green);
        
        if(Physics.Raycast(ray, out hit, 50f))
        {
            if(hit.collider.gameObject.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseLife(1);
            }
        }
    }
}
