﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;


public class Share : MonoBehaviour
{
	private string shareMessage;
	public void Share1()
	{
//		shareMessage = "Ciao il mio score è di " + FindObjectOfType<score>().PunteggioFinale() + " Punti!";

		StartCoroutine(TakeScreenshotAndShare());

	}
	private IEnumerator TakeScreenshotAndShare()
	{
		yield return new WaitForEndOfFrame();

		Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
		ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
		ss.Apply();

		string filePath = Path.Combine(Application.temporaryCachePath, "shared img.png");
		File.WriteAllBytes(filePath, ss.EncodeToPNG());


		Destroy(ss);

		new NativeShare().AddFile(filePath).SetSubject("Ad Gloriam").SetText(shareMessage).Share();

	}

}
