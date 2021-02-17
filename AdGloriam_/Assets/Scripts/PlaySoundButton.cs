using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundButton : MonoBehaviour
{
    public AudioSource source;
    public AudioClip hover;
    public AudioClip click;
    public void loadNextScene()
    {
        StartCoroutine(LoadingLevel());
    }
    IEnumerator LoadingLevel()
    {
        yield return new WaitForSeconds(1f);
        Application.LoadLevel("OtherScene");
    }
    public void Onhover()
    {
        source.PlayOneShot(hover);
    }
    public void OnClick()
    {
        source.PlayOneShot(click);
    }

}
