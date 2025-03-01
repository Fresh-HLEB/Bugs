using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BaseHealth : MonoBehaviour
{
    public Image[] lives;
    private int indexLives;
   
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Obstacle"))
        {
            lives[indexLives -1].enabled = false;         
            UpdateLivesUI();
        }
    }
   
   
    void UpdateLivesUI()
    {

    }
}
