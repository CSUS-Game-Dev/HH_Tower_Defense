using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAlly : MonoBehaviour {

	public GameObject missilePrefab;
	public DefaultMissileScript defaultMissileScript;

	public float timeBetweenMissiles;
	public float timeOfLastMissile;

	public float targetingRange;

	private GameObject target;

	// Use this for initialization
	void Start () {
		timeOfLastMissile = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if(target == null){
			RaycastHit[] targets = Physics.SphereCastAll(transform.position, targetingRange, new Vector3(0f, 1f, 0f), 0f);

			Debug.Log("Raycast found " + targets.Length + " items");

			GameObject bestTarget = null;
			for(int i = 0; i < targets.Length; i++){
				if(targets[i].collider.gameObject.tag == "Enemy"){
					if(bestTarget == null){
						bestTarget = targets[i].collider.gameObject;
					}
					else if(targets[i].collider.gameObject.GetComponent<Enemy>().lifeTime > bestTarget.GetComponent<Enemy>().lifeTime){
						bestTarget = targets[i].collider.gameObject;
					}

				}
			}

			target = bestTarget;
		}
		else{
			if(timeOfLastMissile + timeBetweenMissiles < Time.time && (target.transform.position - transform.position).magnitude < targetingRange){
				fireMissile(target);
			}
			else if((target.transform.position - transform.position).magnitude > targetingRange){
				target = null;
			}
		}
	}

	public void fireMissile(GameObject target){
		if(target == null){
			Debug.Log("Error - Target is null");
			return;
		}
		else{
			GameObject temp = Instantiate(missilePrefab, transform.position + new Vector3(0f, .5f, 0f), Quaternion.identity);
			temp.GetComponent<DefaultMissileScript>().target = target;
			timeOfLastMissile = Time.time;
		}
	}
}
