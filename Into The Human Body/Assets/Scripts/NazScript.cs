using UnityEngine;
using System.Collections;

public class NazScript : MonoBehaviour {

	public float time;

	public float angle;
	public float period;

	void Start () 
	{
		transform.localRotation = Quaternion.Euler (0.0f, 130f, 0.0f);
	}

	void Update () 
	{
		time = time + Time.deltaTime;
		float phase = Mathf.Sin(time / period);
		transform.localRotation = Quaternion.Euler(new Vector3(0, phase * angle + 120, 0));
	}
}
