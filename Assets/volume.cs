using UnityEngine;
using System.Collections;

public class volume : MonoBehaviour {
	public static float MainVolume=5f;
	// Use this for initialization
	void Start () {
		GetComponent<AudioSource>().volume = MainVolume/100;
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<AudioSource>().volume <= MainVolume/10) {
			GetComponent<AudioSource>().volume+=0.01f;
		}
		if (Time.time>10){
		GetComponent<AudioSource>().volume = MainVolume/10;
		}

	}
}
