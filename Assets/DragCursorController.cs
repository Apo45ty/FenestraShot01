using UnityEngine;
using System.Collections;

public class DragCursorController : MonoBehaviour {


	void OnMouseDrag(){
		Debug.Log("Following Mouse");
		float mousex = (Input.mousePosition.x);
		float mousey = (Input.mousePosition.y);
		Vector2 mouseposition = Camera.current.ScreenToWorldPoint(new Vector2 (mousex,mousey));
		transform.position = mouseposition;
	}
}
