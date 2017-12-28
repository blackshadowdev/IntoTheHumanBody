using UnityEngine;
using System.Collections;

public class LaserScript : MonoBehaviour {

	private Animator anim;
	
	void Start () 
	{
		
		Invoke("LaserMove", 45);
		Invoke ("LaserSound",46);
	}
	
	void LaserMove ()
	{
		anim = GetComponent<Animator>();
		anim.SetTrigger("LaserMove");
	}
	
	void LaserSound()
	{
		GetComponent<AudioSource>().Play();
	}


}
