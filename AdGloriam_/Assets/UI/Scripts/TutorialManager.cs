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


        if (popUpindex == 0)
        {
            popUps[0].SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                popUps[0].SetActive(false);
                popUpindex++;

            }
        }
        /* if (popUpindex == 1)
         {
             popUps[0].SetActive(true);
             if (FindObjectOfType<ViewAcolumn>().SeeColumn())
             {
                 popUps[0].SetActive(false);
                 popUpindex++;

             }
         }
    */

    }
}

