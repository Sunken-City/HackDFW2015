using UnityEngine;
using System.Collections;

public class bounce : MonoBehaviour {

	public int force;
	Vector3 position;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}	

	void OnCollisionEnter(Collision c) {
		ContactPoint cp = c.contacts[0];
		// calculate with addition of normal vector
		// myRigidbody.velocity = oldVel + cp.normal*2.0f*oldVel.magnitude;
		
		// calculate with Vector3.Reflect
		c.gameObject.rigidbody.velocity = Vector3.Reflect(c.gameObject.rigidbody.velocity,cp.normal);
		
		// bumper effect to speed up ball
		c.gameObject.rigidbody.velocity += cp.normal*force;
	}
}
