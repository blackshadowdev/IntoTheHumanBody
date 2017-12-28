using UnityEngine;
using System.Collections;

public class VesselScript : MonoBehaviour 
{

	private Animator anim;
	
	void Start () 
	{
		Invoke ("BloodVessel",60);
	}
	
	void BloodVessel ()
	{
		anim = GetComponent<Animator>();
		anim.SetTrigger("BloodVesselAppear");
	}
	
}
