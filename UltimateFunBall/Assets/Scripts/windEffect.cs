using UnityEngine;
using System.Collections;

public class windEffect : MonoBehaviour {

	// 1 = x, 2 = y, -1 = -x, -2 = -2
	public int direction;

	public int speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision other) {
		if (direction == 1) {
			other.gameObject.transform.position = new Vector3 (other.gameObject.transform.position.x + speed, other.gameObject.transform.position.y, other.gameObject.transform.position.z);
		} 
		else if (direction == 2) {
			other.gameObject.transform.position = new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y + speed, other.gameObject.transform.position.z);
		}
		else if (direction == -1) {
			other.gameObject.transform.position = new Vector3 (other.gameObject.transform.position.x - speed, other.gameObject.transform.position.y, other.gameObject.transform.position.z);
		} 
		else if (direction == -2) {
			other.gameObject.transform.position = new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y - speed, other.gameObject.transform.position.z);
		}
	}
}
