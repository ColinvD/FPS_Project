using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Round : MonoBehaviour {

    [SerializeField]
    private Text RoundText;
    private int Rounds = 1;

    // Use this for initialization
    void Start () {
        RoundText.text = Rounds.ToString();
	}
	
	public void AddRound()
    {
        Rounds += 1;
        RoundText.text = Rounds.ToString();
    }
}
