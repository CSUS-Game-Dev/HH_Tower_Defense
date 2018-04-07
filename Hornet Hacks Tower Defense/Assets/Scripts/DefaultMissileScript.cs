using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultMissileScript : MonoBehaviour {

	public GameObject target;
	public float speed;
	
	// Update is called once per frame
	void Update () {
		if(target != null){
			Vector3 direction = target.transform.position - transform.position;
			transform.position = transform.position + direction * speed * Time.deltaTime;
		}
		else{
			Destroy(gameObject, 0f);
		}
	}

	void OnTriggerEnter(Collider collider){
		Debug.Log("Collision detected");
		if(collider.gameObject == target){
			Debug.Log("Destroying");
			Destroy(target, 0f);
			Destroy(gameObject, 0f);
		}
	}
}
