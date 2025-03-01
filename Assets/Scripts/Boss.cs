using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    private float speed = 2f;
    private SpriteRenderer sprite;
    public Slider slider;
    private static float sliderValue = 3;
    private float maxBossHealth = 3;
    public Vector3[] positions;
    private int indexPosition;
    public Transform bossHome;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, positions[indexPosition], speed * Time.deltaTime);
        if(transform.position == positions[indexPosition])
        {
            if(indexPosition < positions.Length -1)
            {
                sprite.flipX = false;
                indexPosition ++;                              
            }
            else
            {
                sprite.flipX = true;
                indexPosition = 0;
            }
        }
        if(slider.value == 0)
        {
            Destroy(gameObject);
        }
        if(slider.value == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, bossHome.position, speed);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
            slider.value -= 1;
        }
        if(collider.gameObject.CompareTag("BossMedicine"))
        {
            slider.value = maxBossHealth;
            sliderValue = slider.value;
            Destroy(collider.gameObject);           
        }
    }
}
