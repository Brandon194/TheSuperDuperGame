using UnityEngine;
using System.Collections;

public class CameraFollowPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 PlayerPos = transform.position;

		Camera.main.transform.position = new Vector3 (PlayerPos.x, PlayerPos.y, -10);
	}
}
