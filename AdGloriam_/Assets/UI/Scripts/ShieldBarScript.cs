using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldBarScript : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 10f;
    float timeLeft;

    
    void Start()
    {
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;

    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<Gladiatore>().isShieldOn())
        {
       
            
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
            Debug.Log(timeLeft);
            if (timeLeft < 0)
            {
                timeLeft = maxTime;
                timerBar.fillAmount = maxTime;
                FindObjectOfType<Gladiatore>().ShieldOff();
            }
          
        }
  

    }
 


    
}
