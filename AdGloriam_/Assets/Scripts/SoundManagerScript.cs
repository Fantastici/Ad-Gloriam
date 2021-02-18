using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip scudoSound;
    static AudioSource audioSrc;


    void Start()
    {
        scudoSound = Resources.Load<AudioClip>("scudoSound");
        audioSrc = GetComponent<AudioSource>();

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "scudoSound":
                audioSrc.PlayOneShot(scudoSound);
                break;
        }
    }


}
