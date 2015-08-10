using UnityEngine;
using System.Collections;

public class WelcomeTrigger : MonoBehaviour {
	
	public GameObject welcomeUp;
	public GameObject welcomeDown;
	public Vector3 upStep;
	public Vector3 downStep;
	public int durationFrame;
	
	private bool hasOpen = false;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			//print (other);
			if (hasOpen) {
				StartCoroutine(WelcomeClose());
			} else {
				StartCoroutine(WelcomeOpen());
			}
			hasOpen = !hasOpen;
		}
	}
	
	IEnumerator WelcomeOpen () {
		for (int i = 0; i < durationFrame; i++) {
			welcomeUp.transform.position += upStep;
			welcomeDown.transform.position += downStep;
			yield return this;
		}
	}
	
	IEnumerator WelcomeClose () {
		for (int i = 0; i < durationFrame; i++) {
			welcomeUp.transform.position -= upStep;
			welcomeDown.transform.position -= downStep;
			yield return this;
		}
	}
	
}
