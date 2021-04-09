using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class GameOverUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GameOver;
	
    
    public void Home(string nome_scena)
    {
        SceneManager.LoadScene(nome_scena);
    }
    public void Restart(string nome_scena)
    {
        SceneManager.LoadScene(nome_scena);
        GameOver.SetActive(false);
		
		
    }

	

}
