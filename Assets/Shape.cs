using UnityEngine;
using System.Collections;

public class Shape : MonoBehaviour {
	public int id =1;
	private bool isClicked = false;
	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
	}
	
	// Update is called once per frame
	void Update () {
		if( isClicked ){
			Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector3 pos = new Vector3(mouse.x,mouse.y,transform.position.z);
			transform.position = pos;
		}
		
		/*
		if(transform.position.x > mouse.x ){
			transform.position += new Vector3(1,0,0);
		} else if(transform.position.x < mouse.x){
			transform.position += new Vector3(-1,0,0);
		}*/
		
	}
	
	void OnMouseDown() {
		isClicked=!isClicked;
	}
}
