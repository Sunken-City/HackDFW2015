using UnityEngine;
using System.Collections;

public class bindXandY : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = new Vector3 (0f, 0.5f, transform.localPosition.z);
	}
}
