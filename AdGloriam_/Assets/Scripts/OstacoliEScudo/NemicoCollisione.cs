using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NemicoCollisione : MonoBehaviour
{
    private  int count;
    private bool verificato = false;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            this.verificato = true;
            this.count += 1;
            if (!FindObjectOfType<Gladiatore>().isShieldOn() && this.count == 1)
            {
               
                Debug.Log(count);
                Debug.Log("ENtrato");
                SoundManagerScript.PlaySound("hit");
                Vector3 posizioneGladia = new Vector3(-9.24f, FindObjectOfType<Gladiatore>().transform.position.y, FindObjectOfType<Gladiatore>().transform.position.z);
                FindObjectOfType<Gladiatore>().transform.position = posizioneGladia;
                FindObjectOfType<Gladiatore>().Damage();
                FindObjectOfType<LifeCount>().LoseLife();
            }
        }
        else
        {
            this.verificato = false;
        }
        count = 0;
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
