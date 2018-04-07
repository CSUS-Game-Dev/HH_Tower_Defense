using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(EnemySpawner)), CanEditMultipleObjects]
public class PosHandleScript : Editor {
/* 
	EnemySpawner example = (EnemySpawner)target;
	public List<Handles.PositionHandle> handles;

	// Use this for initialization
	void Start () {
		handles = new List<Handles.PositionHandle>();
		
		for(int i = 0; i < example.waypoints.Count; i++){
			Vector3 newTargetPosition = Handles.PositionHandle(example.waypoints[i], Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	public void Update () {
	}

	void OnSceneGUI(){
		example = (EnemySpawner)target;

		EditorGUI.BeginChangeCheck();
		for(int i = 0; i < example.waypoints.Count; i++){
			if (EditorGUI.EndChangeCheck())
        	{
				Undo.RecordObject(example, "Moved handle");
				example.waypoints[i] = newTargetPosition;
				example.Update();
        	}
		}

		 
        
        

	}
*/
}
