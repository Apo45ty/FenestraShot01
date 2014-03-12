//using UnityEngine;
//using System.Collections;
//
//public class Shadow : MonoBehaviour {
//	public int id =1;
//	public GameController master;
//	// Use this for initialization
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//	}
//
//	void OnTriggerEnter2D(Collider2D other){
//		Debug.Log("Something has entered this zone. Shadow" + this.id); 
//		Shape elem = other.gameObject.GetComponent<Shape>();
//		if(elem != null && elem.id == this.id ){
//			master.playerScored();
//		}
//
//	} 
//	void OnTriggerExit2D(Collider2D other){
//		Debug.Log("Something has entered this zone.Shadow" + this.id);  
//	} 
//	void OnTriggerStay2D(Collider2D other){
//		Debug.Log("Something has entered this zone.Shadow" + this.id);  
//	} 
//	
//	void OnCollisionEnter2D(Collision2D collision){
//		Debug.Log("something has hit meShadow" + this.id); 
//	} 
//}
