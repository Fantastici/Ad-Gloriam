using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisionPlayer : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        FindObjectOfType<LifeCount>().LoseLife();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collisione in entrata");
    }
}
