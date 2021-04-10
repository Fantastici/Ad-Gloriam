using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
  public void exit()
    {
        Application.Quit();
    }
    public void play(string nome_scena)
    {
        SceneManager.LoadScene(nome_scena);
    }
    public void tutorial(string nome_scena)
    {
        SceneManager.LoadScene(nome_scena);
    }
    public void sound_volume(float volume)
    {
        PlayerPrefs.SetFloat("volume", volume);
    }
}
