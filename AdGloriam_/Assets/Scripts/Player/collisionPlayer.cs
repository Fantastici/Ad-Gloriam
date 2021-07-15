using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class collisionPlayer : MonoBehaviour
{
    private int count = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Arrow"))
        {
            Debug.Log("collisione");
            if (!FindObjectOfType<Gladiatore>().isShieldOn() && this.getCount()==0)
            {
                this.count++;
                SoundManagerScript.PlaySound("hit");
                FindObjectOfType<Gladiatore>().Damage();
                FindObjectOfType<LifeCount>().LoseLife();
                Vector3 posizioneGladia = new Vector3(-9.24f, transform.position.y, transform.position.z);
                FindObjectOfType<Gladiatore>().transform.position = posizioneGladia;
            }
            
        }

        if (collision.gameObject.tag.Equals("Helmet"))
        {
                FindObjectOfType<LifeCount>().addLife();
        }


    }
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collisione in entrata");
    }
    private int getCount()
    {
        return this.count;
    }
}
