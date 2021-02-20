using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    private GameObject heart1;
    private GameObject heart2;
    private GameObject heart3;

    private GameObject gameOver;
    int deathCounter;

    private void Awake()
    {
        heart1 = GameObject.Find("health1");
        heart2 = GameObject.Find("health2");
        heart3 = GameObject.Find("health3");

        gameOver = GameObject.Find("GameOver");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            deathCounter += 1;
            Debug.Log("collisione");
        }
        if (deathCounter == 1)
        {
            Destroy(heart1);
        }
        if (deathCounter == 2)
        {
            Destroy(heart2);
        }
        if (deathCounter == 3)
        {
            Destroy(heart3);
        }
      
    }
}
