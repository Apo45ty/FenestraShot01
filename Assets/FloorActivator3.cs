using UnityEngine;
using System.Collections;

public class FloorActivator3 : MonoBehaviour {
	public Transform prefab;
	private int count = 0;
	public int maxcount = 4;

	void OnTriggerEnter2D(Collider2D other) { 
		TriangleShape elem = other.gameObject.GetComponent<TriangleShape>();
		if (elem != null) {
			count++;
			Debug.Log ("is triangle");
				if (count == maxcount) { 
					Transform wall = Instantiate (prefab, this.transform.position, this.transform.rotation) as Transform;
						}
		} else {
			Debug.Log ("Something other than a square has entered");
		}
	}
}
