using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scudoCollisione : MonoBehaviour
{
    
  void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            SoundManagerScript.PlaySound("scudoSound");
            Destroy(gameObject);
            FindObjectOfType<Gladiatore>().ShieldOn();
        }
    }
   
}
