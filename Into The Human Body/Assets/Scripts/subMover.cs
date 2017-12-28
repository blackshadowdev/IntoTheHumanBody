using UnityEngine;
using System.Collections;

public class subMover : MonoBehaviour {
	public Transform[] waypoints;
	public float speed = 5.0f;
	private float startTime;
	private float journeyLength;
	private int start;
	private int end;
	public bool shouldMove = true;

	// Use this for initialization
	void Start () {
		start = 0;
		end = 1;
		startTime = 0.0f;
		transform.position = waypoints[start].position;
		transform.rotation = waypoints[start].rotation;
		journeyLength = Vector3.Distance(waypoints[start].position, waypoints[end].position);

	}
	
	// Update is called once per frame
	void Update () {
		if (shouldMove){
			float distCovered = (Time.time - startTime) * speed;
			float fracJourney = distCovered / journeyLength;
			transform.position = Vector3.Lerp(waypoints[start].position, waypoints[end].position, fracJourney);
			transform.rotation = Quaternion.Lerp(waypoints[start].rotation, waypoints[end].rotation, fracJourney);

			if (fracJourney > 0.9999) {
				if (end < waypoints.Length - 1) {
					start ++;
					end ++;
					startTime = Time.time;
					journeyLength = Vector3.Distance(waypoints[start].position, waypoints[end].position);
				}
			
			}
		}
	}
}
