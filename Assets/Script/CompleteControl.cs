using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CompleteControl : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			Memo.health = (int)GameObject.Find("Slider").GetComponent<Slider>().value;
			Memo.distance = (int)(12 - Camera.main.transform.position.z);
			Application.LoadLevel("success");
		}
	}
}
