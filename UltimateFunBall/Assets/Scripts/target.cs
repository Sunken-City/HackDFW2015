using UnityEngine;
using System.Collections;

public class target : MonoBehaviour {

	public AudioClip breakSound;

	// Use this for initialization
	void Start () {
		GameController.instance.registerTarget ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		if (breakSound) {
			AudioSource.PlayClipAtPoint (breakSound, new Vector3(0f, 1f, -10f));
		}
		GameController.instance.destroyTarget();
		Destroy (this.gameObject);
	}
}
