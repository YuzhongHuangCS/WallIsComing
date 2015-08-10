using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RunControl : MonoBehaviour {

	public Vector3 runSpeed;
	public Vector3 bounceSpeed;
	public int bounceDurationFrame;
	public Slider slider;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.position += runSpeed * Time.deltaTime;	
	}

	void OnTriggerEnter(Collider other) {
		//print(other);
		if (!other.tag.Equals("Trigger")) {
			StartCoroutine(Bounce());

			if (slider.GetComponent<Slider>().value < 10) {
				Memo.health = 0;
				Memo.distance = (int)(12 - Camera.main.transform.position.z);
				Application.LoadLevel("success");
			} else {
				slider.GetComponent<Slider>().value -= 10;
			}
		}
	}

	IEnumerator Bounce () {
		Vector3 currentSpeed = bounceSpeed;
		//print (currentSpeed);
		for (int i = 0; i < bounceDurationFrame; i++) {
			transform.position += currentSpeed;
			Camera.main.transform.position += currentSpeed;
			currentSpeed /= 1.5f;
			//print (currentSpeed);
			yield return this;
		}
	}
}
