﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavouir : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitpoints = 5;
    public HealthBarBehaviour Healthbar;
    

    void Start()
    {
        Hitpoints = MaxHitpoints;
        Healthbar.SetHealth(Hitpoints, MaxHitpoints);
    }

    public void TakeHit(float damage)

    {
        Hitpoints -= damage;
        Healthbar.SetHealth(Hitpoints, MaxHitpoints);

        if (Hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }

}
