using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (Memo.health == 0) {
			GameObject.Find("Perfect").GetComponent<Text>().text = "One more try!";
			GetComponent<Text>().text = string.Format("Distance: {0}m", Memo.distance);
		} else {
			GetComponent<Text>().text = string.Format("Distance: {0}m, Health {1}", Memo.distance, Memo.health);
		}
		Invoke("ShowScore", 0.5f);
		Invoke("ShowButton", 1.5f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void ShowScore() {
		GetComponent<Animator>().enabled = true;
	}

	void ShowButton() {
		GameObject.Find("BackButton").GetComponent<Animator>().enabled = true;
	}

	void Back() {
		Application.LoadLevel("menu");
	}
}
