using UnityEngine;
using System.Collections;

public class sceneDirector : MonoBehaviour {

	public AudioClip[] narration;
	public AudioClip ding;
	public AudioSource myAudio;
	public int sceneStep;
	public int subStep;
	public Transform focusMarker;
	public GameObject wbc1;
	public GameObject wbc2;
	public GameObject wbc3;
	public GameObject wbc4;
	public GameObject bact1;
	public GameObject bact2;
	public GameObject bact3;
	public GameObject bact4;
	public bool targetHit = false;
	public subMover subMoveScript;

	// for smoothDamp
	private Vector3 velocity = Vector3.zero;
	private float dist;

	// Use this for initialization
	void Start () {
		subMoveScript = GameObject.Find("Submarine").GetComponent<subMover>();
		myAudio = GetComponent<AudioSource>();
		StartCoroutine(SceneStep1());
		//sceneStep = 1;
		//subStep = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (targetHit) {
			if (sceneStep == 5) {
				//StartCoroutine(ObjectMover(wbc1, bact1));
				StartCoroutine(SceneStep6());
			} else if (sceneStep == 7) {
				//StartCoroutine(ObjectMover(wbc2, bact2));
				StartCoroutine(SceneStep8());
			} else if (sceneStep == 8) {
				//StartCoroutine(ObjectMover(wbc3, bact3));
				StartCoroutine(SceneStep9());
			} else if (sceneStep == 9) {
				//StartCoroutine(ObjectMover(wbc4, bact4));
				StartCoroutine(SceneStep10());
			}
			targetHit = false;
		}

		if (sceneStep == 6) {
			wbc1.transform.position = Vector3.SmoothDamp(wbc1.transform.position, bact1.transform.position, ref velocity, 6);
		} else if (sceneStep == 8) {
			wbc2.transform.position = Vector3.SmoothDamp(wbc2.transform.position, bact2.transform.position, ref velocity, 0.8f);
		} else if (sceneStep == 9) {
			wbc3.transform.position = Vector3.SmoothDamp(wbc3.transform.position, bact3.transform.position, ref velocity, 0.8f);
		} else if (sceneStep == 10) {
			wbc4.transform.position = Vector3.SmoothDamp(wbc4.transform.position, bact4.transform.position, ref velocity, 0.8f);
		}
	}

	IEnumerator ObjectMover(GameObject mover, GameObject destination){
		float dist = Vector3.Distance(wbc1.transform.position, bact1.transform.position);
		for (float n = 0; n<3000; n++) {
			mover.transform.position = Vector3.SmoothDamp(mover.transform.position, destination.transform.position, ref velocity, 3);
			yield return null;
		}

	}
		
	IEnumerator SceneStep1(){
		yield return new WaitForSeconds(5);
		StartCoroutine(SceneStep2());
	}


	IEnumerator SceneStep2(){
		// introductory narration while submarine is travelling
		sceneStep = 2;
		myAudio.clip = narration[0];									// "Welcome to the human body."
		myAudio.Play();
		//yield return new WaitForSeconds(myAudio.clip.length);
		yield return new WaitForSeconds(5);
		myAudio.clip = narration[1];									// "The patient is suffering...infection."
		myAudio.Play();
		yield return new WaitForSeconds(myAudio.clip.length);
		myAudio.clip = narration[2];									// "The bacteria...fever, chills."
		myAudio.Play();
	}

	/*
	IEnumerator SceneStep3(){
		// sub continues to destination, then stops
	}
	*/

	IEnumerator SceneStep4(){
		// narration about infection (setup the interaction for player)
		sceneStep = 4;
		myAudio.clip = narration[3];									// "We have reached the site..."
		myAudio.Play();
		yield return new WaitForSeconds(myAudio.clip.length);  
		myAudio.clip = narration[4];									// "Here is a colony of bacteria..."
		myAudio.Play();
		yield return new WaitForSeconds(myAudio.clip.length);
		StartCoroutine(SceneStep5());
	}


	IEnumerator SceneStep5(){
		// put focus marker on 1 white blood cell
		sceneStep = 5;
		myAudio.clip = ding;  											// "Ding!"
		myAudio.Play();  
		focusMarker.position = wbc1.transform.position;
		yield return new WaitForSeconds(myAudio.clip.length);  
		myAudio.clip = narration[6];  									// "This is a white blood cell..."
		myAudio.Play(); 
	}

	IEnumerator SceneStep6(){
		// player looked at the white blood cell
		sceneStep = 6;
		focusMarker.position = new Vector3 (1000,1000,1000);			// remove focus marker
		myAudio.clip = narration[7];  									// "White blood cells are able to detect..."
		myAudio.Play();
		yield return new WaitForSeconds(myAudio.clip.length);
		myAudio.clip = narration[8];  									// "It engulfs bacteria..."
		myAudio.Play();
		yield return new WaitForSeconds(myAudio.clip.length);
		StartCoroutine(SceneStep7());
	}

	IEnumerator SceneStep7(){
		sceneStep = 7;
		myAudio.clip = narration[9];									// "Let's get this place cleaned up."
		myAudio.Play();
		yield return new WaitForSeconds(myAudio.clip.length);
		focusMarker.position = bact2.transform.position;
		myAudio.clip = ding;
		myAudio.Play();
	}

	IEnumerator SceneStep8(){
		sceneStep = 8;
		focusMarker.position = new Vector3 (1000,1000,1000);			// remove focus marker
		myAudio.clip = narration[10];									// "Good!"
		myAudio.Play();
		yield return new WaitForSeconds(myAudio.clip.length);			
		myAudio.clip = ding;
		myAudio.Play();
		focusMarker.position = bact3.transform.position;
	}

	IEnumerator SceneStep9(){
		sceneStep = 9;
		focusMarker.position = new Vector3 (1000,1000,1000);			// remove focus marker
		myAudio.clip = narration[11];									// "Great!"
		myAudio.Play();
		yield return new WaitForSeconds(myAudio.clip.length);
		myAudio.clip = ding;
		myAudio.Play();
		focusMarker.position = bact4.transform.position;
	}

	IEnumerator SceneStep10(){
		sceneStep = 10;
		focusMarker.position = new Vector3 (1000,1000,1000);			// remove focus marker
		myAudio.clip = narration[12];									// "Well done!"
		myAudio.Play();
		yield return new WaitForSeconds(myAudio.clip.length);
		myAudio.clip = narration[13];									// "The patient's WBCs have destroyed the bacteria."
		myAudio.Play();
		wbc1.transform.GetComponent<Rigidbody>().isKinematic = false;	// release the WBCs so they can move away.
		wbc2.transform.GetComponent<Rigidbody>().isKinematic = false;
		wbc3.transform.GetComponent<Rigidbody>().isKinematic = false;
		wbc4.transform.GetComponent<Rigidbody>().isKinematic = false;
		bact1.transform.GetComponent<Renderer>().enabled = false;		// make bacteria invisible
		bact2.transform.GetComponent<Renderer>().enabled = false;
		bact3.transform.GetComponent<Renderer>().enabled = false;
		bact4.transform.GetComponent<Renderer>().enabled = false;
		yield return new WaitForSeconds(myAudio.clip.length);
		myAudio.clip = narration[14];									// "Let's move on to our next challenge..."
		myAudio.Play();
		subMoveScript.shouldMove = true;
		
		// SCENE ENDER
		Invoke ("SceneEnd", 5);
	}

	void SceneEnd()
	{
		Application.LoadLevel("EndScene");
	}

	public void EndOfPath(){
		StartCoroutine(SceneStep4());
		subMoveScript.shouldMove = false;
	}
}
