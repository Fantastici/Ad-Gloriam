using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
  public void exit()
    {
        Application.Quit();
    }
    public void play(string nome_scena)
    {
        Application.LoadLevel(nome_scena);
    }
}
