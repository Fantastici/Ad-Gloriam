using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(GameObject.Find("back sound on") == null)
        {
            GetComponent<AudioSource>().Play();
            gameObject.name = "backsound";
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("volume");
    }
}
