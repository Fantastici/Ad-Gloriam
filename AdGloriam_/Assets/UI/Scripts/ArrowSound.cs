using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSound : MonoBehaviour
{
    // Start is called before the first frame update
    public void sound_volume(float volume)
    {
        PlayerPrefs.SetFloat("volume", volume);
    }
    

}
