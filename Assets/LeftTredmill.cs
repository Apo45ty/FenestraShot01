using UnityEngine;
using System.Collections;

public class LeftTredmill : MonoBehaviour {
	public float dx = 0.5f;
	public float dy = 0.5f;
	void OnTriggerEnter2D(Collider2D collisionObject) {

		collisionObject.gameObject.transform.Translate (Vector3.left * dx*Time.deltaTime);
		collisionObject.gameObject.transform.Translate (Vector3.up * dy*Time.deltaTime);
		collisionObject.gameObject.transform.Rotate (Vector3.up * Time.deltaTime, Space.World);
		}
}
