using UnityEngine;
using System.Collections;

public class destroyOnCollide : MonoBehaviour {

	public AudioClip breakSound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		if (breakSound) {
			AudioSource.PlayClipAtPoint (breakSound, Vector3.zero);
		}
		Debug.Log ("Destroyin'");	
		Destroy (this.gameObject);
	}
}
