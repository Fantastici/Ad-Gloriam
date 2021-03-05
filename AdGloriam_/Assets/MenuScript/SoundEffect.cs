using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public AudioSource sword;
    
    // Start is called before the first frame update
        public void PlaySword()
    {
        sword.Play();
    }
    
}
