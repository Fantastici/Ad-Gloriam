using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    private int popUpindex;

    // Update is called once per frame
    void Update()
    {
        bool c = isClick();
        
        if (popUpindex == 0)
        {

            Time.timeScale = 0;
            popUps[0].SetActive(true);
            if (c)
            {
                Debug.Log(c);
                popUps[0].SetActive(false);
                popUpindex++;
                Time.timeScale = 1;
                c = false;
                Debug.Log(c);
            }
            
        }

        if (popUpindex == 1 && FindObjectOfType<score>().PunteggioFinale().Equals("II"))
         {
         
            popUps[1].SetActive(true);
            Time.timeScale = 0;
            if (c)
            {
                Debug.Log(c);
                popUps[1].SetActive(false);
                popUpindex++;
                Time.timeScale = 1;
                c = false;
                Debug.Log(c);
            }

         }

        if (popUpindex == 2 && FindObjectOfType<score>().PunteggioFinale().Equals("III"))
        {
           
            popUps[2].SetActive(true);
            Time.timeScale = 0;
            if (c)
            {
                Debug.Log(c);
                popUps[2].SetActive(false);
                popUpindex++;
                Time.timeScale = 1;
                c = false;
                Debug.Log(c);
            }

        }


    }
    private bool isClick()
    {
        if (Input.GetMouseButtonUp(0))
        {
            return true;
        }
        else
            return false;
    }

 
}

