using UnityEngine;
using System.Collections;

public class NarrativeScript : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Invoke ("PlayNarrative", 5);
	}
	
	
	void Update () {
	
	}
	
	void PlayNarrative()
	{
		GetComponent<AudioSource>().Play ();
	}
}
