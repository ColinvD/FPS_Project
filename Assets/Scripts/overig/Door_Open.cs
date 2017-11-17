using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Open : MonoBehaviour{
    bool Dead = false;
    [SerializeField]
    private Fall doorOpen;
    [SerializeField]
    private KillsAmount currentKills;
    
    private void OnCollisionEnter(Collision other)
    {
       
        if (other.collider.tag == "wall")
        {
            currentKills.OpenDoor();
            if (Dead == true)
            {
              
                doorOpen.Falling();
                Dead = false;
            }
          
            
        }
    }
    public void Destroy()
    {
       
        Dead = true;
    }


}
