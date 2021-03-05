using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour
{
    public Image[] lives;
    public int livesRemaining;

    public void LoseLife()
    {
        if (livesRemaining == 0)
        {
            return;
        }
        livesRemaining--;
        if (livesRemaining == 2)
        {
            FindObjectOfType<LifeAnimator1>().animator.SetTrigger("Life1Death");
        }
        if (livesRemaining == 1)
        {
            FindObjectOfType<LifeAnimator2>().animator.SetTrigger("Life2Death");
        }
        if (livesRemaining == 0)
        {
            FindObjectOfType<LifeAnimator3>().animator.SetTrigger("Life3Death");
            FindObjectOfType<Gladiatore>().Die();
        }
        //lives[livesRemaining].gameObject.SetActive(false);
       

    }
    // Start is called before the first frame update
    public int GetLivesRemaing()
    {
        return livesRemaining;
    }
    // Update is called once per frame
   void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoseLife();
        }
    }
}
