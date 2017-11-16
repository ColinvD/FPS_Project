﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public float health = 100f;
    private int maxTime = 5;
    private int currentTime;
    private int minute = 60;
    private float second;

    private int damaged;
    private int healed;

    void Start()
    {
        currentTime = maxTime;
    }

    void FixedUpdate()
    {
        if (second >= minute)
        {
            currentTime -= 1;
            second = 0;
        }
        else
        {
            second += Time.fixedDeltaTime * 60;
        }
    }

    public void LoseHealth(float amount)
    {
        if (currentTime <= 0)
        {
            health -= amount;
            currentTime = maxTime;
            damaged += (int)amount;
        }
    }

    public void GainHealth(float amount)
    {
        int hp = (int)health;

        if(health < 100f)
        {
            health += amount;
        }
        if(health > 100f)
        {
            health = 100f;
        }

    }

    public int GetDamaged()
    {
        return damaged;
    }
}
