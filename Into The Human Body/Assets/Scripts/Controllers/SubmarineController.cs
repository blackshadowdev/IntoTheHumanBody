using UnityEngine;
using System.Collections;

public class SubmarineController : MonoBehaviour
{
    public Transform startPoint;
    public Transform controlPoint;
    public Transform endPoint;
    public float speed = 1.0f;
    public float turnSpeed = 1.5f;
    private float startTime;
    private float journeyLength;
    public bool isReached = false;

    
	// Use this for initialization
	void Start ()
    {
        startTime = Time.time;
        journeyLength = Vector2.Distance(startPoint.position, controlPoint.position);
	}
	
	// Update is called once per frame
	void Update ()
    {
        

       
       // transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));

        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        transform.position = Vector3.Lerp(startPoint.position, controlPoint.position, fracJourney);

        if(transform.position == controlPoint.position)
        {
            Vector3 direction = new Vector3(endPoint.position.x, endPoint.position.y, endPoint.position.z) - transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, turnSpeed * Time.deltaTime);
            // transform.position = Vector3.Lerp(transform.position, endPoint.position, fracJourney);
            controlPoint.position = Vector3.MoveTowards(controlPoint.position, endPoint.position, speed * Time.deltaTime);
            //Debug.Log("Reached destination");
            isReached = true;
        }


	}
}
