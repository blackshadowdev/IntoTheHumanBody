using UnityEngine;
using System.Collections;

public class HumScript : MonoBehaviour 
{

	void Start () 
	{
		
		Invoke ("Hum",50);
	}
	
	void Hum ()
	{
		GetComponent<AudioSource>().Play();
	}

}
