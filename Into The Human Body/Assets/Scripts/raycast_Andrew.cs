using UnityEngine;
using System.Collections;

public class raycast_Andrew : MonoBehaviour {

	//public sceneDirector directorScript as Component;
	private sceneDirector directorScript;

	// Use this for initialization
	void Start () {
		directorScript = GameObject.Find("Scene Director").GetComponent<sceneDirector>();
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		if (Physics.Raycast(transform.position, fwd, out hit, 400)) {
			if (hit.transform.name == "Focus Marker 2") {
				Debug.Log("hit = " + hit.transform.name);
				directorScript.targetHit = true;
			}
		}
	}
}
