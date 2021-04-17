using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehaviour : MonoBehaviour
{
    public Slider Slider;
    public Color low;
    public Color high;
    public Vector3 offset;

    public void SetHealth(float health, float Maxhealth)
    {
        Slider.gameObject.SetActive(health < Maxhealth);
        Slider.value = health;
        Slider.maxValue = Maxhealth;
        
        Slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(low,high,Slider.normalizedValue);
    }
    

    void Update()
    {
        Slider.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position = offset);
        
    }
}
