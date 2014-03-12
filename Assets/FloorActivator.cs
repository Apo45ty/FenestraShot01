using UnityEngine;
using System.Collections;

public class FloorActivator : MonoBehaviour {
	public Transform prefab;
	private int count = 0;
	public int maxcount = 4;
	
	void OnTriggerEnter2D(Collider2D other) { 
		CircleShape elem = other.gameObject.GetComponent<CircleShape>();
		if (elem != null) {
			count++;
			Debug.Log ("is circle");
				if (count == maxcount) { 
					Transform wall = Instantiate (prefab, this.transform.position, this.transform.rotation) as Transform;
						}
		} else {
			Debug.Log ("Something other than a circle has entered");
		}
	}
}
