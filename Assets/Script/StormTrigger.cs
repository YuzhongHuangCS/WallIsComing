using UnityEngine;
using System.Collections;

public class StormTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			GameObject.Find("Storm2_peak").GetComponent<ParticleSystem>().enableEmission = true;
			GameObject.Find("Storm_Ground").GetComponent<ParticleSystem>().enableEmission = true;
		}
	}
}
