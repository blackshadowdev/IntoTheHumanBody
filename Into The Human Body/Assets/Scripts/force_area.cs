using UnityEngine;
using System.Collections;

public class force_area : MonoBehaviour
{

    public Vector3 forceAngle;
    public Transform aim;
   
    // Use this for initialization
    void Start()
    {
        //forceAngle = transform.rotation.eulerAngles;  // this worked, sort of, but pushed everything straight up;
        forceAngle = transform.forward;

        //Quaternion quat = Quaternion.LookRotation(aim);
        //forceAngle = quat.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "redBloodCell")
        {
            //RbcScript rbcScript = other.GetComponent<rbcScript>();
            //rbcScript.forceAngle = forceAngle;
            other.GetComponent<rbcScript>().forceAngle = forceAngle;
        }

        if (other.tag == "whiteBloodCell")
        {
            //RbcScript rbcScript = other.GetComponent<rbcScript>();
            //rbcScript.forceAngle = forceAngle;
            other.GetComponent<wbcAndrew>().forceAngle = forceAngle;
        }
        //other.attachedRigidbody.AddForce(forceAngle * 1);
        //other.attachedRigidbody.Move(forceAngle * 1);
        //other.Move(forceAngle * 1);
    }
}
