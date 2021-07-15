using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class collisionPlayer : MonoBehaviour
{
    private int count = 0;
    private bool verificato = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
     
        if (collision.gameObject.tag.Equals("Arrow"))
        {

            this.verificato = true;
            Debug.Log(FindObjectOfType<Gladiatore>().transform.position.x);
            if (!FindObjectOfType<Gladiatore>().isShieldOn() && count==0)
            {
                this.count++;
                SoundManagerScript.PlaySound("hit");
                FindObjectOfType<Gladiatore>().Damage();
                FindObjectOfType<LifeCount>().LoseLife();
             

            }
          
        }
        else
        {
            this.verificato = false;
        }

        if (collision.gameObject.tag.Equals("Helmet"))
        {
                FindObjectOfType<LifeCount>().addLife();
        }


    }
    void Update()
    {
        if (this.verificato)
        {
            Vector3 posizioneGladia = new Vector3(-9.24f, FindObjectOfType<Gladiatore>().transform.position.y, FindObjectOfType<Gladiatore>().transform.position.z);
            FindObjectOfType<Gladiatore>().transform.position = posizioneGladia;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collisione in entrata");
    }
  
}
