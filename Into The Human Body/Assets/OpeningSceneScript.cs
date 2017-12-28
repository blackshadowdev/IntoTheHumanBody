using UnityEngine;
using System.Collections;

public class OpeningSceneScript : MonoBehaviour {

	public GameObject Particles;
	
	void Start () 
	{
		Invoke("ParticlesGo", 90);
	}
	
	
	void Update () {
	
	}
	
	void ParticlesGo()
	{
		Particles.gameObject.SetActive(true);
		GetComponent<AudioSource>().Play ();
		Invoke("LoadNextLevel", 5);
	}
	
	void LoadNextLevel()
	{
		Application.LoadLevel("BloodScene");
	}
}
