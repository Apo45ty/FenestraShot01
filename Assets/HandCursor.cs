using UnityEngine;
using System.Collections;

public class HandCursor : MonoBehaviour {
	public float offsetX =1;
	public float offsetY =-1;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector3 pos = new Vector3(mouse.x+offsetX,mouse.y+offsetY,transform.position.z);
		transform.position = pos;
	}
}