using UnityEngine;
using System.Collections;

public class rbc_spawner : MonoBehaviour {

	public Transform rbcPrefab;
	public float timer = 1.0f;
	private float lastSpawnTime = 0.0f;
	private Vector3 spawnPos;
	private Quaternion spawnRot;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Time.time > lastSpawnTime + timer) {
			spawnPos = transform.position + Random.insideUnitSphere * 2.5f;
			spawnRot = Random.rotation;
			Instantiate(rbcPrefab, spawnPos, spawnRot);
			lastSpawnTime = Time.time;
		}
	}
}
