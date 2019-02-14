using UnityEngine;
using System.Collections;

public class AtmosphereAudioScript : MonoBehaviour
{
    AudioSource audioSource;

	// Use this for initialization
	void Awake () 
	{
        audioSource = FindObjectOfType<AudioSource>();
		StartCoroutine (VolumeFadeUp());
	}
	
	IEnumerator VolumeFadeUp()
	{
		Debug.Log("Voluming Raising");
		for ( int i = 0; i <= 20; i ++)
		{
			audioSource.volume = 0.01f * i; 
			yield return new WaitForSeconds(0.1f);
		}

        yield return null;
	}
}
