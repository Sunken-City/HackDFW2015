using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject confetti;
	public string nextLevel;

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
		yield return new WaitForSeconds(3);
	}

	void finishLevel()
	{
		Instantiate (confetti, new Vector3(0f, 0f, 0f), new Quaternion());
		StartCoroutine ("wait");
		Application.LoadLevel (nextLevel);
	}
}
