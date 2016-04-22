using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	float DeltaXOld, DeltaYOld;
	float DeltaX = 0f, DeltaY = 0f;

	void Update () {
		TestKey ();

		if (DeltaX != 0) {
			if (DeltaX > 0)
				DeltaX = DeltaX - .01F;
			if (DeltaX < 0)
				DeltaX = DeltaY + .01F;
		}
			

		if (DeltaXOld != DeltaX || DeltaX == 0f)
		transform.position = new Vector3 (transform.position.x + DeltaX, transform.position.y + DeltaY, transform.position.z);

	}

	void TestKey(){
		if (Input.GetKey ("a"))
			DeltaX = -.1f;

		if (Input.GetKey ("d"))
			DeltaX = .1f;

		if (Input.GetKeyDown ("space"))
			DeltaY = .1f;
	}
}
