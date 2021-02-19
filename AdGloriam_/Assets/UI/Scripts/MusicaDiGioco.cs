using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaDiGioco : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(GameObject.Find("backsound on")==null)
        {
            GetComponent<AudioSource>().Play();
            gameObject.name = "backsound on";
            PlayerPrefs.SetFloat("volume", 0.1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("volume");
    }
}
