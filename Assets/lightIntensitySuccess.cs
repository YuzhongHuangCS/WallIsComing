using UnityEngine;
using System.Collections;
using System;

public class lightIntensitySyccess : MonoBehaviour {
	static float intensity = 0f;
	Color a=new Color(0,0,0);

	// Use this for initialization
	void Start () {

	}

	

	// Update is called once per frame
	void Update () {
		if (intensity < 1.0f) {
			GetComponent<Light>().intensity = 0.0f+intensity;
			intensity  += 0.002f;
			a+=new Color(0.002f,0.002f,0.002f);
			RenderSettings.ambientLight=a;
		}
	}

}
