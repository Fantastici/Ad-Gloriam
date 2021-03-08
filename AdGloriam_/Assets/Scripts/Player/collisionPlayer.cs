using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisionPlayer : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Arrow"))
        {
            Debug.Log("collisione");
            if (!FindObjectOfType<Gladiatore>().isShieldOn())
            {
                SoundManagerScript.PlaySound("hit");
                FindObjectOfType<Gladiatore>().Damage();
                FindObjectOfType<LifeCount>().LoseLife();
            }
            
        }

        
    }
}
