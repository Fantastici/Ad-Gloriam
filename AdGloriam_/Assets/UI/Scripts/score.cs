using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoreText;
    public Text highScore;

    private static Text hs;
    public static float HighScore=1f;
    public float scoreAmount;
    public float pointIncreasePerSecond;
    public static bool verificato = false;
    // Start is called before the first frame update
    void Start()
    {
        
        scoreAmount = 1f;
        pointIncreasePerSecond = 0.5f;
    }
   
    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<Gladiatore>().isDead == false && FindObjectOfType<Gladiatore>().isOut == false)
        {
            scoreText.text = ToRoman((int)scoreAmount);
            scoreAmount += pointIncreasePerSecond * Time.deltaTime;
        }



        if (HighScore < scoreAmount && FindObjectOfType<Gladiatore>().isDead == false && FindObjectOfType<Gladiatore>().isOut == false)
        {

            highScore.text = ToRoman((int)scoreAmount);
            highScore.color = Color.green;
           
        }
        else
        {
            highScore.text = ToRoman((int)HighScore);
        }


    }

   /* public float getScoreAmount()
    {
       
        scoreAmount += pointIncreasePerSecond * 0;
        return scoreAmount;
    }*/


    public String PunteggioFinale()
    {
        if (HighScore < scoreAmount)
        {
            
            HighScore = scoreAmount;
            

        }
      

       
        scoreText.text = ToRoman((int)scoreAmount);
        return scoreText.text;
       
    }
   
    public  string ToRoman(int number)
    {
        if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
        if (number < 1) return string.Empty;
        if (number >= 1000) return "M" + ToRoman(number - 1000);
        if (number >= 900) return "CM" + ToRoman(number - 900);
        if (number >= 500) return "D" + ToRoman(number - 500);
        if (number >= 400) return "CD" + ToRoman(number - 400);
        if (number >= 100) return "C" + ToRoman(number - 100);
        if (number >= 90) return "XC" + ToRoman(number - 90);
        if (number >= 50) return "L" + ToRoman(number - 50);
        if (number >= 40) return "XL" + ToRoman(number - 40);
        if (number >= 10) return "X" + ToRoman(number - 10);
        if (number >= 9) return "IX" + ToRoman(number - 9);
        if (number >= 5) return "V" + ToRoman(number - 5);
        if (number >= 4) return "IV" + ToRoman(number - 4);
        if (number >= 1) return "I" + ToRoman(number - 1);
        throw new ArgumentOutOfRangeException("something bad happened");
    }
}

