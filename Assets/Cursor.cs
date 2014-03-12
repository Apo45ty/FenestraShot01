using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour {

	public float mousePositionX = 1.5f;
	public float mousePositionY = 1.5f;
	public float forceXTresholdInner = 1.6f;
	public float forceYTresholdInner = 1.6f;
	public float forceXTresholdMiddle = 10;
	public float forceYTresholdMiddle = 10;

	public float forceMinYInner = 2;
	public float forceMinXInner = 2;
	public float forceMinYMiddle = 15;
	public float forceMinXMiddle = 15;
	public float forceMinYOutter = 125;
	public float forceMinXOutter = 125;

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
			if(Mathf.Abs(transform.position.x - pos.x) <= mousePositionX && Mathf.Abs(transform.position.y - pos.y) <= mousePositionY){
				rigidbody2D.velocity=Vector3.zero;
				rigidbody2D.gravityScale = 0;
			} else if(Mathf.Abs(transform.position.x - pos.x) < forceXTresholdInner && Mathf.Abs(transform.position.y - pos.y) < forceYTresholdInner){
				rigidbody2D.AddForce(new Vector2((pos.x - transform.position.x )*(forceMinXInner),(pos.y - transform.position.y )*(forceMinYInner) ));
			} else if(Mathf.Abs(transform.position.x - pos.x) < forceXTresholdMiddle && Mathf.Abs(transform.position.y - pos.y) < forceYTresholdMiddle){
				rigidbody2D.AddForce(new Vector2((pos.x - transform.position.x )*(forceMinXMiddle),(pos.y - transform.position.y )*(forceMinYMiddle) ));
			} else {
				rigidbody2D.AddForce(new Vector2((pos.x - transform.position.x)*(forceMinXOutter),(pos.y - transform.position.y)*(forceMinYOutter)));
			}
		}

		/*
		if(transform.position.x > mouse.x ){
			transform.position += new Vector3(1,0,0);
		} else if(transform.position.x < mouse.x){
			transform.position += new Vector3(-1,0,0);
		}*/
		
	}

	void OnMouseDown() {
		//isClicked=!isClicked;
		rigidbody2D.gravityScale = 0;
	}

	void OnMouseUp() {
		//isClicked=!isClicked;
		rigidbody2D.gravityScale = 1;
	}

	void OnMouseDrag() {
		Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector3 pos = new Vector3(mouse.x,mouse.y,transform.position.z);
		if(Mathf.Abs(transform.position.x - pos.x) <= mousePositionX && Mathf.Abs(transform.position.y - pos.y) <= mousePositionY){
			rigidbody2D.velocity=Vector3.zero;
		} else if(Mathf.Abs(transform.position.x - pos.x) < forceXTresholdInner && Mathf.Abs(transform.position.y - pos.y) < forceYTresholdInner){

			rigidbody2D.AddForce(new Vector2((pos.x - transform.position.x )*(forceMinXInner),(pos.y - transform.position.y )*(forceMinYInner) ));
		} else if(Mathf.Abs(transform.position.x - pos.x) < forceXTresholdMiddle && Mathf.Abs(transform.position.y - pos.y) < forceYTresholdMiddle){

			rigidbody2D.AddForce(new Vector2((pos.x - transform.position.x )*(forceMinXMiddle),(pos.y - transform.position.y )*(forceMinYMiddle) ));
		} else {
			rigidbody2D.AddForce(new Vector2((pos.x - transform.position.x)*(forceMinXOutter),(pos.y - transform.position.y)*(forceMinYOutter)));
		}
	}
}