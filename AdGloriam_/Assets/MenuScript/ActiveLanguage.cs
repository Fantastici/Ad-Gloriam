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
        Debug.Log(isLanguage.èIt);

        if (isLanguage.èIt)
        {
            Debug.Log("Italiano");
            It.SetActive(true);
            Eng.SetActive(false);
        }
        else if (isLanguage.èIng)

        {
            Debug.Log("Eng");
            Eng.SetActive(true);
            It.SetActive(false);
        }

    }
}
