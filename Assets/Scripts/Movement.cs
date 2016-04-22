using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("a"))
			transform.position = new Vector3 (transform.position.x - .2f, transform.position.y, transform.position.z);
		
		if (Input.GetKeyDown ("d"))
			transform.position = new Vector3 (transform.position.x + .2f, transform.position.y, transform.position.z);
		
		if (Input.GetKeyDown ("space"))
			transform.position = new Vector3 (transform.position.x, transform.position.y + .2f, transform.position.z);
	}
}
