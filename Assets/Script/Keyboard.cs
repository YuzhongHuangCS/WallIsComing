using UnityEngine;
using System.Collections;

public class Keyboard : MonoBehaviour {
	
	public Vector3 xSpeed;
	public Vector3 ySpeed;
	public Vector3 zSpeed;

	public void Start () {
	
	}

	public void Update () {
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.position += xSpeed;
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.position -= xSpeed;
		}
		if (Input.GetKey(KeyCode.UpArrow)) {
			transform.position += ySpeed;
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			transform.position -= ySpeed;
		}
		if (Input.GetKey(KeyCode.X)) {
			transform.position += zSpeed;
		}
		if (Input.GetKey(KeyCode.Z)) {
			transform.position -= zSpeed;
		}
	}
}
