using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject confetti;
	public string nextLevel;
	public AudioClip tada;
	public AudioClip yay;
	public float waitTime = 5.0f;

	[HideInInspector]
	public static GameController instance;

	[HideInInspector]
	public int targetCount;

	// Use this for initialization
	void Start () {

	}

	void Awake() {
		if (instance) {
			Destroy(instance.gameObject);
		}
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void registerTarget()
	{
		targetCount++;
	}

	public void destroyTarget()
	{
		targetCount--;
		if (targetCount == 0) {
			finishLevel();
		}
	}

	public IEnumerator wait() {
		AudioSource.PlayClipAtPoint (tada, new Vector3(0f, 5f, 0f));
		yield return new WaitForSeconds(2);
		AudioSource.PlayClipAtPoint (yay, new Vector3(0f, 5f, 0f));
		yield return new WaitForSeconds(waitTime - 2);
		Application.LoadLevel (nextLevel);
	}

	void finishLevel()
	{
		Instantiate (confetti);
		StartCoroutine ("wait");
	}
}
