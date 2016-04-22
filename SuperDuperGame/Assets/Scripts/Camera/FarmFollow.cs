using UnityEngine;
using System.Collections;

public class FarmFollow : MonoBehaviour {

	Vector2 oldMousePosition;

	float MouseMovedX, MouseMovedY;

	bool MouseDown = false;


	void Update(){
		if (Input.GetMouseButtonDown (0)) {
			MouseDown = true;
			oldMousePosition = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp (0)) {
			MouseDown = false;
		}

		MouseMovedX = oldMousePosition.x - Input.mousePosition.x;
		MouseMovedY = oldMousePosition.y - Input.mousePosition.y;

		oldMousePosition = Input.mousePosition;

		Vector3 MoveCamera = new Vector3 (-MouseMovedX/10, -MouseMovedY/10, -10);

		float CameraX = transform.position.x + MoveCamera.x;
		float CameraY = transform.position.y + MoveCamera.y;

		Vector3 CameraPos = new Vector3(
			transform.position.x,
			transform.position.y,
			-10
		);

		if (-9.75 < CameraX  && CameraX < 10){
			CameraPos.x = CameraX;
		}
		if (-11.75 < CameraY && CameraY < 10){
			CameraPos.y = CameraY;
		}

		if (MouseDown)
			transform.position = CameraPos;
	}

}
