using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Open : MonoBehaviour{
    bool Dead = false;
    [SerializeField]
<<<<<<< HEAD
    private Fall[] doorOpen;
    [SerializeField] private KillsAmount currentKills;
=======
    private Fall doorOpen;
    [SerializeField]
    private KillsAmount currentKills;
>>>>>>> 71e70d914b2ab32da1edaddddf03b5f0b3a4186a
    
    void Start()
    {
<<<<<<< HEAD
        doorOpen = FindObjectsOfType<Fall>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Wall")
=======
       
        if (other.collider.tag == "wall")
>>>>>>> 71e70d914b2ab32da1edaddddf03b5f0b3a4186a
        {
            currentKills.OpenDoor();
            if (Dead == true)
            {
<<<<<<< HEAD
                for (int i = 0; i < doorOpen.Length; i++)
                {
                    doorOpen[i].Falling();
                }
=======
              
                doorOpen.Falling();
>>>>>>> 71e70d914b2ab32da1edaddddf03b5f0b3a4186a
                Dead = false;
            }
          
            
        }
    }
    public void Destroy()
    {
       
        Dead = true;
    }


}
