using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class ActiveLanguage: MonoBehaviour
{

    public GameObject It;
    public GameObject Eng;

    // Update is called once per frame
    void Update()
    {


        if (isLanguage.èIt)
        {
          
            It.SetActive(true);
            Eng.SetActive(false);
        }
        else if (isLanguage.èIng)

        {
            
            Eng.SetActive(true);
            It.SetActive(false);
        }

    }
}
