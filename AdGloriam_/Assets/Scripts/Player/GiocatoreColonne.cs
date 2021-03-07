using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiocatoreColonne : MonoBehaviour
{
    public float columnSpeed;
  
    void Start()
    {
        columnSpeed = FindObjectOfType<column>().getColumnSpeed();
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag.Equals("Column"))
        {

            Debug.Log("collisione");
               // FindObjectOfType<Gladiatore>().aumentaSpeed();
        }
    }
    
}
