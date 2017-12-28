using UnityEngine;
using System.Collections;

public class wbcAndrew : MonoBehaviour {
	private Rigidbody rb;
	public Vector3 forceAngle;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		rb.AddForce(forceAngle * 0.01f);
	}
}
