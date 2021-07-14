using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickPauseMenu : MonoBehaviour
{
  
 
   
    public GameObject PauseButton;
    public GameObject MenuDiPausa;
    bool GamePaused;


    // Start is called before the first frame update
    void Start()
    {
        GamePaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GamePaused)
        {
            Time.timeScale = 0;
        }
        else
            Time.timeScale = 1;
    }

    public void PauseGame()
    {
        
        GamePaused = true;
        MenuDiPausa.SetActive(true);
        PauseButton.SetActive(true);
        
    }
    public void LoadMenu()
    {
        GamePaused = false;
        SceneManager.LoadScene("MainMenu");
    }

    public void ResumeGame()
    {
        GamePaused = false;
        MenuDiPausa.SetActive(false);
        PauseButton.SetActive(true);
        }
    public void sound_volume(float volume)
    {
        PlayerPrefs.SetFloat("volume", volume);
    }
    public void Restart(string nome_scena)
    {
        SceneManager.LoadScene(nome_scena);
        MenuDiPausa.SetActive(false);


    }
}
