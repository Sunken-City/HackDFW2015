using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

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

	void finishLevel()
	{
		Debug.Log ("winner winner chickun dinnur");
	}
}
