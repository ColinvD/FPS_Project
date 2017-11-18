using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Open : MonoBehaviour{
    bool Dead = false;
    [SerializeField]
    private Fall[] doorOpen;
    [SerializeField] private KillsAmount currentKills;
    
    void Start()
    {
        doorOpen = FindObjectsOfType<Fall>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Wall")
        {
            currentKills.OpenDoor();
            if (Dead == true)
            {
                for (int i = 0; i < doorOpen.Length; i++)
                {
                    doorOpen[i].Falling();
                }
                Dead = false;
            }
          
            
        }
    }
    public void Destroy()
    {
        Dead = true;
    }


}
