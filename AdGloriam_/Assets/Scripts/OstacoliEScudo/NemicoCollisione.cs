using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NemicoCollisione : MonoBehaviour
{
    private float xgladiatoreprimadicontatto;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            if (!FindObjectOfType<Gladiatore>().isShieldOn())
            {
                SoundManagerScript.PlaySound("hit");
                FindObjectOfType<Gladiatore>().Damage();
                FindObjectOfType<LifeCount>().LoseLife();
                this.xgladiatoreprimadicontatto = FindObjectOfType<Gladiatore>().transform.position.x;
                Vector3 posizioneGladia = new Vector3(this.xgladiatoreprimadicontatto, FindObjectOfType<Gladiatore>().transform.position.y, FindObjectOfType<Gladiatore>().transform.position.z);
                FindObjectOfType<Gladiatore>().transform.position = posizioneGladia;
            }
        }
        
       
    }
    
}
