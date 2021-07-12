using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
public class isLanguage : MonoBehaviour
{
    public GameObject It;
    public GameObject Eng;
    public static bool èIt;
    public static bool èIng;


    public bool IsItalian()
    {
        if (It.activeSelf)
        {
            return true;
        }
        return false;
    }

    public bool IsEnglish()
    {
        if (Eng.activeSelf)
        {
            return true;
        }
        return false;
 
    }


    void Update()
    {
        èIt = IsItalian();
        èIng = IsEnglish();
        
    }
}
