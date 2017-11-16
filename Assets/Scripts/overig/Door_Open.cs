using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Open : MonoBehaviour{
    bool Dead = false;
    [SerializeField] private KillsAmount currentKills;
    
    private void OnCollisionEnter(Collision other)
    {

        print(currentKills);
        if (other.collider.tag == "wall")
        {
            currentKills.OpenDoor();
            if (Dead == true)
            {
                Destroy(other.gameObject);
                Dead = false;
            }
          
            
        }
    }
    public void Destroy()
    {
        Dead = true;
    }


}
