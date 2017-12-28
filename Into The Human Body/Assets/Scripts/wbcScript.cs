using UnityEngine;
using System.Collections;

public class wbcScript : MonoBehaviour
{

    public Vector3 forceAngle;
    private Rigidbody rb;
    private GameObject wbc;
    private GameObject forceAreaReturn;
    public bool isEnabled = false;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        wbc = GameObject.Find("whiteBloodCell");
        //returningPoint = GameObject.FindGameObjectWithTag("returningPoint");
        //forceAreaReturn = GameObject.FindGameObjectWithTag("forceAreaReturn");

        // add random torque to the WBC so that it is spinning slightly
        float tX = Random.Range(-5.0f, 5.0f);
        float tY = Random.Range(-5.0f, 5.0f);
        float tZ = Random.Range(-5.0f, 5.0f);
        Vector3 newTorque = new Vector3(tX, tY, tZ);
        rb.AddTorque(newTorque);
    }

    // Update is called once per frame
    void Update()
    {
        if(isEnabled == true)
        {
            rb.AddForce(forceAngle * 0.0f);
        }
        else
            rb.AddForce(forceAngle * 0.004f);
    }


    // OnTriggerStay is called once per frame for every Collider other that is touching the trigger
    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "forceAreaReturn")
        {
            rb.AddForce(-forceAngle * 0.05f);
            isEnabled = true;
        }
    }

    // OnTriggerExit is called when the Collider other has stopped touching the trigger
    /*public void OnTriggerExit(Collider other)
    {
        rb.AddForce(forceAngle * 0.0f);
    }*/
}
