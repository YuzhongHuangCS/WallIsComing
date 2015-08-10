using UnityEngine;
using System.Collections;

public class ColorMove : MonoBehaviour {

	public int orientation = 0;
	public int frameMax = 64;
	public Vector3 speed;
	
	private int currentFrame;
	private int currentCount;
	
	// Use this for initialization
	void Start () {
		if (transform.rotation.eulerAngles.x.Equals(90)) {
			orientation = 1;
		} else {
			if (System.Math.Abs(transform.rotation.eulerAngles.y - 90) < 1) {
				orientation = 0;
			} else {
				orientation = 2;
			}
		}
		switch (orientation) {
		case 0:
			speed = new Vector3((Random.value - 0.5f) / 50, 0, 0);
			break;
		case 1:
			speed = new Vector3(0, (Random.value - 0.5f) / 50, 0);
			break;
		case 2:
			speed = new Vector3(0, 0, (Random.value - 0.5f) / 50);
			break;
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
