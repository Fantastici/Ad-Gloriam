using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
    //private ScoreManager theScoreManager;
    void start()
    {
        //theScoreManager = FindObjectOfType<ScoreManager>();
    }
    public void Restart()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //theScoreManager.scoreCount = 0;
        //theScoreManager.scoreIncreasing = true;
        
    }
    
}
