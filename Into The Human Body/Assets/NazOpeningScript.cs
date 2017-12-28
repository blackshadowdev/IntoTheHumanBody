using UnityEngine;
using System.Collections;

public class NazOpeningScript : MonoBehaviour {

	private Animator anim;
	
	void Start () 
	{
		
		Invoke("NazAppear", 75);
	}
	
	void NazAppear ()
	{
		anim = GetComponent<Animator>();
		anim.SetTrigger("NazAppear");
		Debug.Log("CALLED");
	}
	
}

