using UnityEngine;
using System.Collections;

public class AtmosphereAudioScript : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (VolumeFadeUp());
	}
	
	
	void Update () 
	{

	}
	
	IEnumerator VolumeFadeUp()
	{
		Debug.Log("Voluming Raising");
		for ( int i = 0; i <= 20; i ++)
		{
			GetComponent<AudioSource>().volume = 0.01f * i; 
			yield return new WaitForSeconds(0.1f);
		}
	}
}
