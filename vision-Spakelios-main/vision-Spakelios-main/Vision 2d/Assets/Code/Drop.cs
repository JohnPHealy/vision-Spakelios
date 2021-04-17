using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public int dropValue = 1;
    
    private void OnTriggerEnter2D(Collider2D other)

    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.ChangeScore(dropValue);
        }
    }
}
