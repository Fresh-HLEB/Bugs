using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public Slider slider;
    private static float sliderValue = 10;
    private float maxHealth = 10;
    void Start()
    {
        slider.value = sliderValue;
    }
    void Update()
    {
        if(slider.value == 0)
        {
            Debug.Log("Game Over");
        }
    }
    private void OnCollisionEnter2D (Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            slider.value -= 1;
            sliderValue = slider.value;
        }
        if(collision.gameObject.CompareTag("Medicine"))
        {
            slider.value = maxHealth;
            sliderValue = slider.value;
            Destroy(collision.gameObject);
        }
    }
}
