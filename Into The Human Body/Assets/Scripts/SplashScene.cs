using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScene : MonoBehaviour
{
    public AudioSource _audio;

	public void PlayAudio()
	{
		_audio.Play ();
	}

	void LoadNextScene()
	{
		SceneManager.LoadScene("OpeningScene");
	}
}
