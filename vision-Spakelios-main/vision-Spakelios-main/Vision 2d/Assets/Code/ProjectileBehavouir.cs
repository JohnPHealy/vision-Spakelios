using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavouir : MonoBehaviour
{
    public float speed = 4;

    public void Update()
    {
        transform.position += transform.right * (Time.deltaTime * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       var enemy = collision.collider.GetComponent<EnemyBehavouir>();
       if (enemy)
       {
           enemy.TakeHit(1);
       } 
       Destroy(gameObject);
    }
}
