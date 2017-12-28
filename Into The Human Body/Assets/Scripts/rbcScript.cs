using UnityEngine;
using System.Collections;

public class rbcScript : MonoBehaviour {

	public Vector3 forceAngle;
	private Rigidbody rb;
    private GameObject rbc;

    // Use this for initialization
    void Start () {

		rb = GetComponent<Rigidbody>();

        //rbc = GameObject.Find("redbloodCell");
        // add random torque to the RBC so that it is spinning slightly
        float tX = Random.Range(-5.0f, 5.0f);
		float tY = Random.Range(-5.0f, 5.0f);
		float tZ = Random.Range(-5.0f, 5.0f);
		Vector3 newTorque = new Vector3 (tX, tY, tZ);
		rb.AddTorque(newTorque);

        Destroy(gameObject, 20);
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        rb.AddForce(forceAngle * 0.01f);
	}
}
