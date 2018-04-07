using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemyPrefab;

	public List<Waypoint> waypoints;

	public float timeBetweenSpawns = 1f;
	public float timeOfLastSpawn;

	// Use this for initialization
	void Start () {
		/* 
		GameObject temp = Instantiate(enemyPrefab, waypoints[0].transform.position, Quaternion.identity);
		temp.GetComponent<Enemy>().waypoints = waypoints;
		*/
		timeOfLastSpawn = Time.time;

	}
	
	// Update is called once per frame
	public void Update () {
		
		if(timeOfLastSpawn + timeBetweenSpawns < Time.time){
			timeOfLastSpawn = Time.time;
			GameObject temp = Instantiate(enemyPrefab, waypoints[0].transform.position, Quaternion.identity);
			temp.GetComponent<Enemy>().waypoints = waypoints;
		}
		
	}

}
