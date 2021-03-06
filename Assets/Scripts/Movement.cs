﻿using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	float DeltaXOld, DeltaYOld;
	float DeltaX = 0f, DeltaY = 0f;

	void Update () {
		TestKey ();

		if (DeltaX > 0)
			DeltaX = DeltaX - .01f;
		if (DeltaX < 0)
			DeltaX = DeltaX + .01f;

		if (DeltaXOld != DeltaX || DeltaX == 0f)
		transform.position = new Vector3 (transform.position.x + DeltaX, transform.position.y + DeltaY, transform.position.z);

	}

	void TestKey(){
		if (Input.GetKey ("a"))
			DeltaX = -.1f;

		if (Input.GetKey ("d"))
			DeltaX = .1f;

		if (!Input.GetKey ("d") && !Input.GetKey ("a"))
			DeltaX = DeltaX;

		if (Input.GetKeyDown ("space"))
			DeltaY = .1f;
	}
}
