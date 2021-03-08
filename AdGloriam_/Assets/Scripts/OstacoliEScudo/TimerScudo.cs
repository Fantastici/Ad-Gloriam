using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScudo : MonoBehaviour
{
    public bool timeIsRunning = true;
    public float timeRemaining = 10;
    public float secondsRemaining;
    
  
    public bool Timee()
    {
        if (timeIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
             
            }
            else
            {
                Debug.Log("Time has run put!");
                timeIsRunning = false;
            }
        }
        return timeIsRunning;
    }
   
}
