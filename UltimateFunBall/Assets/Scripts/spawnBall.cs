using UnityEngine;
using System.Collections;

public class spawnBall : MonoBehaviour {

	public GameObject ball;
	//float lastStartTime = 0.0f;
	//public float reloadTime = 3.0f;
	public float velocityMultiplier = 2.0f;
	Vector3 launcherPosition = new Vector3 (0f, 0.5f, 0.2f);	//the original position of the launcher ball

	// Use this for initialization
	void Start () {
		if (velocityMultiplier <= 0) {
			velocityMultiplier = 2.0f;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		//if (collision.collider.gameObject.CompareTag("Projectile") && (Time.time - lastStartTime > reloadTime)) {
		if (collision.collider.gameObject.CompareTag("Projectile")) {
			//lastStartTime = Time.time;

			//spawn a projectile just past the slingshot and give it the launcher ball's velocity
			GameObject projectile = Instantiate(ball, gameObject.transform.position + new Vector3(0f, 0f, 1f), Quaternion.identity) as GameObject;
			projectile.rigidbody.velocity = transform.parent.transform.parent.transform.forward * collision.relativeVelocity.magnitude * velocityMultiplier;

			//reset the launcher ball's position and velocity to starting values
			collision.transform.localPosition = launcherPosition;
			collision.transform.rigidbody.velocity = Vector3.zero;
		}
	}
}
