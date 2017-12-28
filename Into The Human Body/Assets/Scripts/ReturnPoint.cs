using UnityEngine;
using System.Collections;

public class ReturnPoint : MonoBehaviour {

    private GameObject returningPoint;
    private GameObject forceAreaReturn;
    private GameObject forceArea2;
    private GameObject forceAreaTurn;

    // Use this for initialization
    void Start ()
    {
        forceAreaReturn = GameObject.FindGameObjectWithTag("forceAreaReturn");
        forceAreaReturn.SetActive(false);
        forceArea2 = GameObject.Find("force area 2");
        forceAreaTurn = GameObject.Find("force area Turn");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    // OnTriggerEnter is called when the Collider other enters the trigger
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "whiteBloodCell")
        {
            //rb.AddForce(-forceAngle * 10f);
            forceAreaReturn.SetActive(true);
            //forceArea2.GetComponent<Collider>().isTrigger = false;
            //forceAreaTurn.SetActive(false);
            //forceArea2.SetActive(false);

        }
    }
}
