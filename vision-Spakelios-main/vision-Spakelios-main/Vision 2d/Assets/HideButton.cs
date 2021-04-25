using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HideButton : MonoBehaviour 
{
public GameObject Button;

private void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.CompareTag("Eye"))
    {
        Button.SetActive(true);
    }

}

}
