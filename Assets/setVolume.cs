using UnityEngine;
using System.Collections;

public class setVolume : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<AudioSource>().volume = volume.MainVolume/500;
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<AudioSource>().volume < volume.MainVolume/10) {
			GetComponent<AudioSource>().volume+=volume.MainVolume/1000;
		}
		if (GetComponent<AudioSource>().volume >= volume.MainVolume/10)
			GetComponent<AudioSource>().volume=volume.MainVolume/10;
	}
}


