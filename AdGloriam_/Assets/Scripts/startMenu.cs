using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startMenu : MonoBehaviour
{
   public void exit()
    {
        Application.Quit();
    }
    public void play (string nome_scena)
    {
        Application.LoadLevel(nome_scena);
    }
    public void sound_volume(float volume)
    {
        PlayerPrefs.SetFloat("volume",volume);
    }
}
