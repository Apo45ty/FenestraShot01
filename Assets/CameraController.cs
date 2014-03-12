//using UnityEngine;
//using System.Collections;
//
//public class CameraController : MonoBehaviour {
//	public Transform leftBoundary;
//	public Transform rightBoundary;
//	public float  damping = 1;
//	public float followDistance = 2;
//	// Use this for initialization
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//		if(mouse.x > leftBoundary.position.x && mouse.x < rightBoundary.position.x){
//			if(Mathf.Abs(mouse.x - transform.position.x)> followDistance ){
//				Vector3 pos = new Vector3(mouse.x,transform.position.y,transform.position.z);
//				transform.position = Vector3.Lerp (transform.position, pos, Time.deltaTime * damping);
//			}
//		} 
//	}
//}
