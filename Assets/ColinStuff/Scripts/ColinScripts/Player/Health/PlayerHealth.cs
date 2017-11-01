using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public float health = 100f;
    private int MaxTime = 5;
    private int CurrentTime;
    private int minute = 60;
    private float second;

    void Start()
    {
        CurrentTime = MaxTime;
    }

    void FixedUpdate()
    {
        if (second >= minute)
        {
            CurrentTime -= 1;
            second = 0;
        }
        else
        {
            second += Time.fixedDeltaTime * 60;
        }
    }

    public void LoseHealth(float amount)
    {
        if (CurrentTime <= 0)
        {
            health -= amount;
            CurrentTime = MaxTime;
        }
    }

    public void GainHealth(float amount)
    {
        if(health < 100f)
        {
            health += amount;
        }
        if(health > 100f)
        {
            health = 100f;
        }
    }
}
