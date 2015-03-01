using UnityEngine;
using System.Collections;

public class fixRotation : MonoBehaviour {

	Vector3 referenceForward;
	Vector3 referenceRight;

	// Use this for initialization
	void Start () {
		
		// the vector that we want to measure an angle from
		referenceForward = new Vector3 (1f, 0f, 0f);
		
	}

	// Update is called once per frame
	void LateUpdate () {
		// the vector of interest
		Vector3 newDirection = transform.localPosition;

		transform.localPosition = referenceForward * Vector3.Dot (newDirection, referenceForward) + new Vector3(0f, 0.5f, 0.2f);
	}
}
