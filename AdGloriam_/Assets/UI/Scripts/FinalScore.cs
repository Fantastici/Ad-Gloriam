using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text scoreText;
    public float scoreAmount;
    public float pointIncreasePerSecond;
    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 1f;
        pointIncreasePerSecond = 6f;
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<Gladiatore>().isDead)
        {
            if(!scoreText.text.Equals(FindObjectOfType<score>().PunteggioFinale()))
            {
                scoreText.text = FindObjectOfType<score>().ToRoman((int)scoreAmount);
                scoreAmount += pointIncreasePerSecond * Time.deltaTime;
                
            }
            if (scoreText.text.Equals(FindObjectOfType<score>().PunteggioFinale()))
            {
                Time.timeScale = 0;
            }
        }
        if (FindObjectOfType<Gladiatore>().isOut)
        {
            if (!scoreText.text.Equals(FindObjectOfType<score>().PunteggioFinale()))
            {
                scoreText.text = FindObjectOfType<score>().ToRoman((int)scoreAmount);
                scoreAmount += pointIncreasePerSecond * Time.deltaTime;

            }
            if (scoreText.text.Equals(FindObjectOfType<score>().PunteggioFinale()))
            {
                Time.timeScale = 0;
            }
        }

    }
}