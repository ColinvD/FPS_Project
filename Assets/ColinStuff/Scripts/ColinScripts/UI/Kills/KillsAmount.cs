using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillsAmount : MonoBehaviour {
    [SerializeField]
    private Door_Open Open;
    [SerializeField]
    private Text killsText;
    private Text CoinsText;
    private int kills = 0;
    private int Coins = 0;

    // Use this for initialization
    void Start () {
        killsText.text = kills.ToString();
       // CoinsText.text = Coins.ToString();
    }
	
	// Update is called once per frame
	

    public void AddKills ()
    {
        Coins++;
        kills++;
        killsText.text = kills.ToString();
      //  CoinsText.text = Coins.ToString();
    }
    public void OpenDoor ()
    {
       
            if (Coins >= 10)
            {
         
            for (int i = 1; i <= 10; i++)
            {
                Coins--;
            }
            Open.Destroy();
            }
        }
    
}
