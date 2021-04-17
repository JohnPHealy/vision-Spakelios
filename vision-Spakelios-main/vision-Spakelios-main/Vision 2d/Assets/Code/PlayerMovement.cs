using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public ProjectileBehavouir ProjectilePrefab;
    public Transform launchOffset;
   
    public float speed;
    private Vector2 targetPosition;
    void Start()
    {
        
       // targetPosition = new Vector2(0.0f, 0.0f);
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            targetPosition = Input.mousePosition;
            targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(targetPosition.x, targetPosition.y, 0.0f));
        }
        this.transform.position = Vector2.MoveTowards(this.transform.position, targetPosition, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ProjectilePrefab, launchOffset.position, transform.rotation);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("collect")) 
        {
            Destroy(other.gameObject);
        }
    }
}
