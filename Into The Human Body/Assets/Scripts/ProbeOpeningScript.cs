using UnityEngine;
using System.Collections;

public class ProbeOpeningScript : MonoBehaviour {

	private Animator anim;
	
	void Start () 
	{
		
        Invoke("ProbeAnim", 30);
	}

    void ProbeAnim ()
    {
        anim = GetComponent<Animator>();
        anim.SetTrigger("Submove");
            Debug.Log("CALLED");
     }

}
