using UnityEngine;
using System.Collections;

public class trigEndOfPath : MonoBehaviour {
	private sceneDirector directorScript;

	// Use this for initialization
	void Start () {
		directorScript = GameObject.Find("Scene Director").GetComponent<sceneDirector>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player"){
			directorScript.EndOfPath();
			gameObject.SetActive(false);
		}
	}
}
