using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavouir : MonoBehaviour
{
    public float speed = 4.5f;

    public void Update()
    {
        transform.position += -transform.right * Time.deltaTime * speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
}
