using UnityEngine;
using System.Collections;

public class LaserMove : MonoBehaviour {

	public bool isLeft = false;
	public int frameMax = 64;
	public Vector3 speed;

	private int currentFrame;
	private int currentCount;

	// Use this for initialization
	void Start () {
		speed = new Vector3(Random.value / 50, 0, 0);
		if (isLeft) {
			speed *= -1;
		}
		currentFrame = 0;
		currentCount = (int)(Random.value * frameMax);
	}
	
	// Update is called once per frame
	void Update () {
		if (currentFrame < currentCount) {
			currentFrame++;
		} else {
			currentFrame = 0;
			currentCount = (int)(Random.value * frameMax);
			speed *= -1;
		}
		transform.position += speed;
	}
}
