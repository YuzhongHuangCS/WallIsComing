using UnityEngine;
using System.Collections;

public class KeyboardControl : MonoBehaviour {
	public Vector3 xSpeed;
	public Vector3 ySpeed;
	public Vector3 zSpeed;

	public void Update () {
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.position += xSpeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.position -= xSpeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.UpArrow)) {
			transform.position += ySpeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			transform.position -= ySpeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.X)) {
			transform.position += zSpeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Z)) {
			transform.position -= zSpeed * Time.deltaTime;
		}
	}
}
