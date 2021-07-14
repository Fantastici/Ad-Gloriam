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

                popUps[0].SetActive(false);
                FindObjectOfType<Gladiatore>().setJumpforce(23f);
                popUpindex++;
                Time.timeScale = 1;
                c = false;

            }

        }
        if (popUpindex == 1)
        {

            Time.timeScale = 0;
            popUps[1].SetActive(true);
            if (c)
            {

                popUps[1].SetActive(false);
                FindObjectOfType<Gladiatore>().setJumpforce(23f);
                popUpindex++;
                Time.timeScale = 1;
                c = false;

            }

        }
        if (popUpindex == 2)
        {

            Time.timeScale = 0;
            popUps[2].SetActive(true);
            if (c)
            {
                popUps[2].SetActive(false);
                FindObjectOfType<Gladiatore>().setJumpforce(23f);
                popUpindex++;
                Time.timeScale = 1;
                c = false;
            }

        }

        if (popUpindex == 3)
        {

            Time.timeScale = 0;
            popUps[3].SetActive(true);
            if (c)
            {
                popUps[3].SetActive(false);
                FindObjectOfType<Gladiatore>().setJumpforce(23f);
                popUpindex++;
                Time.timeScale = 1;
            }

        }

        if (popUpindex == 4 && FindObjectOfType<score>().PunteggioFinale().Equals("II"))
        {

            popUps[4].SetActive(true);
            Time.timeScale = 0;
            FindObjectOfType<Gladiatore>().setJumpforceaZero();
            if (c)
            {
                
                popUps[4].SetActive(false);
                FindObjectOfType<Gladiatore>().setJumpforce(23f);
                popUpindex++;
                Time.timeScale = 1;
            }

        }

        if (popUpindex == 5 && FindObjectOfType<score>().PunteggioFinale().Equals("III"))
        {
            popUps[5].SetActive(true);
            Time.timeScale = 0;
            if (c)
            {
                
               
                popUps[5].SetActive(false);
                FindObjectOfType<Gladiatore>().setJumpforce(23f);
                popUpindex++;
                Time.timeScale = 1;
             

            }

        }
        if (popUpindex == 6 && FindObjectOfType<score>().PunteggioFinale().Equals("IV"))
        {
          
            popUps[6].SetActive(true);
            Time.timeScale = 0;
            if (c)
            {
                popUps[6].SetActive(false);
                FindObjectOfType<Gladiatore>().setJumpforce(23f);
                popUpindex++;
                Time.timeScale = 1;
            }

        }
        if (popUpindex == 7 && FindObjectOfType<score>().PunteggioFinale().Equals("V"))
        {

            popUps[7].SetActive(true);
            Time.timeScale = 0;
            if (c)
            {
                popUps[7].SetActive(false);
                FindObjectOfType<Gladiatore>().setJumpforce(23f);
                popUpindex++;
                Time.timeScale = 1;
            }

        }
        if (popUpindex == 8 && FindObjectOfType<score>().PunteggioFinale().Equals("VI"))
        {
            FindObjectOfType<Gladiatore>().setJumpforceaZero();
            popUps[8].SetActive(true);
            Time.timeScale = 0;
            if (c)
            {
                popUps[8].SetActive(false);
                popUpindex++;
                Time.timeScale = 1;
            }

        }
        if (popUpindex == 9 && FindObjectOfType<score>().PunteggioFinale().Equals("IX"))
        {
            
            popUps[9].SetActive(true);
            Time.timeScale = 0;
            if (c)
            {
                popUps[9].SetActive(false);
                popUpindex++;
                Time.timeScale = 1;
            }

        }
        if (popUpindex == 10 && FindObjectOfType<score>().PunteggioFinale().Equals("X"))
        {
           //FindObjectOfType<Gladiatore>().setJumpforceaZero();
            popUps[10].SetActive(true);
            if (c)
            {
                popUps[10].SetActive(false);
                popUpindex++;
                c = false;
            }
        }
        if (popUpindex == 11)
        {
            //FindObjectOfType<Gladiatore>().setJumpforceaZero();
            popUps[11].SetActive(true);
            if (c)
            {
                popUps[11].SetActive(false);
                popUpindex++;
                c = false;
            }
        }
        if (popUpindex == 12)
        {
            //FindObjectOfType<Gladiatore>().setJumpforceaZero();
            popUps[12].SetActive(true);
            if (c)
            {
                popUps[12].SetActive(false);
                popUpindex++;
                c = false;
            }
        }
        if (popUpindex == 13)
        {
            //FindObjectOfType<Gladiatore>().setJumpforceaZero();
            popUps[13].SetActive(true);
            if (c)
            {
                popUps[13].SetActive(false);
                popUpindex++;
                c = false;
            }
        }
        if (popUpindex == 14)
        {
            //FindObjectOfType<Gladiatore>().setJumpforceaZero();
            popUps[14].SetActive(true);
            if (c)
            {
                popUps[14].SetActive(false);
                popUpindex++;
                c = false;
            }
        }

    }
    private bool isClick()
    {
        if (Input.GetMouseButtonUp(0))
        {
            FindObjectOfType<Gladiatore>().setJumpforceaZero();
            return true;
        }
        else
            return false;
    }

 
}

