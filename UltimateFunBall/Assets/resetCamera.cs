using UnityEngine;
using System.Collections;

public class resetCamera : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if (Input.GetKeyDown ("space")) {
			OVRManager.display.RecenterPose();
		}
	}
}
