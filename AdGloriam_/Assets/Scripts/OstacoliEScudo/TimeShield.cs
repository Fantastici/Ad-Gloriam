using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeShield : MonoBehaviour
{

    public float timeleft = 10f;
    [SerializeField] Text Timer;
   
    public void time()
    {
            FindObjectOfType<TimeAnimator>().animator.SetBool("TimeOn",true);
            timeleft -=  Time.deltaTime;
            Timer.text = timeleft.ToString("0");
            if (timeleft <= 0)
            {
            FindObjectOfType<TimeAnimator>().animator.SetBool("TimeOn", false);
         
            FindObjectOfType<Gladiatore>().ShieldOff();
            timeleft = 10f;
                
            }
      
    }
    public void setTimer()
    {
        timeleft = 10f;
    }


}
