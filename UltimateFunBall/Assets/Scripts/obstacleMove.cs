using UnityEngine;
using System.Collections; 

public class obstacleMove : MonoBehaviour {
	
	public enum Direction {x, y, z};
	public Direction direction;
	public float speed;
	public float distance;
	private float xStartPosition;
	
	void Start () {
		if (direction == Direction.x) {
			xStartPosition = transform.position.x - distance/2;
		}
		else if (direction == Direction.y) {
			xStartPosition = transform.position.y - distance/2;
		}
		else if (direction == Direction.z) {
			xStartPosition = transform.position.z - distance/2;
		}
	}
	void Update () {
		if (direction == Direction.x) {
			if ((speed < 0 && transform.position.x < xStartPosition) || (speed > 0 && transform.position.x > xStartPosition + distance))
			{
				speed *= -1;
			}
			transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
		}
		else if (direction == Direction.y) {
			if ((speed < 0 && transform.position.y < xStartPosition) || (speed > 0 && transform.position.y > xStartPosition + distance))
			{
				speed *= -1;
			}
			transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);
		}
		else if (direction == Direction.z) {
			if ((speed < 0 && transform.position.z < xStartPosition) || (speed > 0 && transform.position.z > xStartPosition + distance))
			{
				speed *= -1;
			}
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed * Time.deltaTime);
		}
	}
}
