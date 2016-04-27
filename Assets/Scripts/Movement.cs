using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	float DeltaXOld, DeltaYOld;
	float DeltaX = 0f, DeltaY = 0f;

	void Start(){
		
	}

	void Update () {
		TestKey ();

		if (DeltaX != 0) {
			if (DeltaX > 0)
				DeltaX = DeltaX - .01F;
			if (DeltaX < 0)
				DeltaX = DeltaX + .01F;
			if (DeltaX > -0.01F && DeltaX < 0.01F)
				DeltaX = 0;
		}

		if (DeltaY > .01F)
			DeltaY = DeltaY - 0.001F;
		if (DeltaY < .01F)
			DeltaY = 0F;

		var go = GameObject.Find ("New Sprite");

		go.transform.position = new Vector3 (transform.position.x + 2, transform.position.y, transform.position.z);



		if (DeltaXOld != DeltaX || DeltaX == 0f)
		transform.position = new Vector3 (transform.position.x + DeltaX, transform.position.y + DeltaY, transform.position.z);

	}

	void TestKey(){
		if (Input.GetKey ("a"))
			DeltaX = -.05f;

		if (Input.GetKey ("d"))
			DeltaX = .05f;

		if (Input.GetKeyDown ("space"))
			DeltaY = .05f;
	}
}
