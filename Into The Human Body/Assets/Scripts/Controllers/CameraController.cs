using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    //public float torque = 1.0f;
    
	
	void Update ()
    {
        DetectInput();
	}

    private void DetectInput()
    {
        float throttle = Input.GetAxis("Vertical");
        float steer = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.LeftShift))
        {
            // GetComponent<Rigidbody>().AddForce(transform.up * 1);
            transform.Rotate(Vector3.left, Time.deltaTime * 10);
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.Rotate(Vector3.right, Time.deltaTime * 10);
            //GetComponent<Rigidbody>().AddForce(-transform.up * 1);
        }

        GetComponent<Rigidbody>().AddForce(transform.forward * throttle);
        GetComponent<Rigidbody>().transform.Rotate(new Vector3(0, steer, 0));
    }
}
