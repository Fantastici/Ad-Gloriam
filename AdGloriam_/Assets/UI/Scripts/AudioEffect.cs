using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEffect : MonoBehaviour
{
    public AudioSource swordpause;

    // Start is called before the first frame update
    public void PlaySword()
    {
        swordpause.Play();
    }

}
