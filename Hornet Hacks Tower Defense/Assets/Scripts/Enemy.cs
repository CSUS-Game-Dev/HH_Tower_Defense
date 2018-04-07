using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float health;

	public List<Waypoint> waypoints;
	public int nextWaypoint = 0;

	public float moveSpeed = 1f;

	public float distanceFromDestination = .05f;

	public float lifeTime = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if((transform.position - waypoints[nextWaypoint].transform.position).magnitude < distanceFromDestination){
			nextWaypoint++;
		}
		else{
			Vector3 direction = (waypoints[nextWaypoint].transform.position - transform.position).normalized;
			transform.position = transform.position + direction * moveSpeed * Time.deltaTime;
		}


		if(nextWaypoint >= waypoints.Count){
			Destroy(gameObject, 0f);
		}

		lifeTime += Time.deltaTime;
	}

	void takeDamage(float damage){
		health = health - damage;
		if(health < 0f){
			Destroy(gameObject, 0f);
		}
	}

}
