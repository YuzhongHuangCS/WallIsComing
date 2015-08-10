using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {
	
	public GameObject doorLeft;
	public GameObject doorRight;
	public Vector3 leftStep;
	public Vector3 rightStep;
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
			if (hasOpen) {
				StartCoroutine(DoorClose());
			} else {
				StartCoroutine(DoorOpen());
			}
			hasOpen = !hasOpen;
		}
	}
	
	IEnumerator DoorOpen () {
		for (int i = 0; i < durationFrame; i++) {
			doorLeft.transform.position += leftStep;
			doorRight.transform.position += rightStep;
			yield return this;
		}
	}
	
	IEnumerator DoorClose () {
		for (int i = 0; i < durationFrame; i++) {
			doorLeft.transform.position -= leftStep;
			doorRight.transform.position -= rightStep;
			yield return this;
		}
	}
	
}
