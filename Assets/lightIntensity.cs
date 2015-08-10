using UnityEngine;
using System.Collections;
using System;

public class lightIntensity : MonoBehaviour {
	static float intensity = 0f;
	static float intensity2 = 0f;
	Color a=new Color(0,0,0);

	// Use this for initialization
	void Start () {

	}

	

	// Update is called once per frame
	void Update () {
		if (Time.time < 3 && intensity < 0.3f) {
			GetComponent<Light>().intensity = 0.0f+intensity;
			intensity  += 0.002f;
			a+=new Color(0.002f,0.002f,0.002f);
			RenderSettings.ambientLight=a;
		}
		if (Time.time > 5) {
			GetComponent<Light>().intensity = 0.3f - intensity2;
			intensity2 += 0.002f;
			a-=new Color(0.002f,0.002f,0.002f);
			RenderSettings.ambientLight=a;
		}
		if (intensity2 >= 0.3f) {
			Application.LoadLevel ("menu");
		}
	}

}
