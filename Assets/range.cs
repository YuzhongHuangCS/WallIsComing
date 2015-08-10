using UnityEngine;
using System.Collections;

public class range : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > 3.4 && Time.time <5.4 && GetComponent<Light>().range<50) {
			GetComponent<Light>().range += 2;
		}
	}
}
