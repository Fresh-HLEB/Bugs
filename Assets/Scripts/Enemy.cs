using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    private float speed = 2f;
    private SpriteRenderer sprite;
    public Vector3[] positions;
    private int indexPosition;
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
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
