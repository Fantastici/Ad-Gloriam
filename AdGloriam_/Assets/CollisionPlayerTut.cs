﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayerTut : MonoBehaviour
{
    private int count = 0;
    private bool verificato = false;
private bool verifica()
    {
        if (FindObjectOfType<isLanguage>().IsEnglish())
        {
            this.count = 0;
            return true;
        }
        else
        {
            return false;
        }
    }
private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Arrow") && (this.count == 0 || verifica()))
        {
            FindObjectOfType<Gladiatore>().isOut = false;
            this.verificato = true;
            this.count += 1;

            if (!FindObjectOfType<Gladiatore>().isShieldOn())
            {


                SoundManagerScript.PlaySound("hit");
                FindObjectOfType<Gladiatore>().Damage();
                FindObjectOfType<LifeCount>().LoseLife();
                Debug.Log(this.count);

            }

        }
     


        if (collision.gameObject.CompareTag("Helmet"))
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
}
