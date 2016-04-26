using UnityEngine;
using System.Collections;

public class StageStayPut : MonoBehaviour {
	Vector3 StartPos;
	Quaternion StartRotation;

	// Use this for initialization
	void Start () {
		StartPos = transform.position;
		StartRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = StartPos;
		transform.rotation = StartRotation;
	}
}
