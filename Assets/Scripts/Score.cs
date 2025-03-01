using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int count;
    public TextMeshProUGUI scoreText;
    void Start()
    {
        count = 0;
        scoreText.text = " " + count.ToString();
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter2D (Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Coin"))
        {
            count++;
            scoreText.text = " " + count.ToString();
            Destroy(collision.gameObject);
        }
    }
}
