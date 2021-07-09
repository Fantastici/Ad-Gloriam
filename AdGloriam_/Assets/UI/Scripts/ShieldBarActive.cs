using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBarActive : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bar;

    // Update is called once per frame
   void Update()
    {
        if (FindObjectOfType<Gladiatore>().isShieldOn())
        {
            bar.SetActive(true);
        }
        else
        {
            bar.SetActive(false);
        }
    }
}
