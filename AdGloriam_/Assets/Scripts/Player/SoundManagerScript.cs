using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip scudoSound;
    public static AudioClip swordSound;
    public static AudioClip hit;
    static AudioSource audioSrc;


    void Start()
    {
        scudoSound = Resources.Load<AudioClip>("scudoSound");
        swordSound = Resources.Load<AudioClip>("sword_sound2");
        hit = Resources.Load<AudioClip>("hit");
        audioSrc = GetComponent<AudioSource>();

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "scudoSound":
                audioSrc.PlayOneShot(scudoSound);
                break;
            case "sword_sound2":
                audioSrc.PlayOneShot(swordSound);
                break;
            case "hit":
                audioSrc.PlayOneShot(hit);
                break;
        }
    }


}
