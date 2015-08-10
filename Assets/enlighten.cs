using UnityEngine;
using System.Collections;

public class enlighten : MonoBehaviour {
	float intensity=3.5f;
	public static int firstTime=0;
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt ("lastQuality") == 0) {
			configure.quality = 4;
		} else {
			configure.quality = PlayerPrefs.GetInt ("lastQuality")-1;
		}
		if (PlayerPrefs.GetInt ("lastAnti") == 0) {
			configure.AntiAliasing = 2;
		} else {
			configure.AntiAliasing = PlayerPrefs.GetInt ("lastAnti")-1;
		}
		volume.MainVolume=PlayerPrefs.GetFloat("lastVolume");
		/*firstTime = PlayerPrefs.GetInt ("firstTime");
		if (firstTime==0) {
			configure.AntiAliasing=2;
			firstTime=1;
			PlayerPrefs.SetInt("firstTime",firstTime);
		}*/
		configure.isFullScreen = PlayerPrefs.GetInt ("isFullScreen");
		if (configure.isFullScreen == 0) {
			configure.fullScreen=true;
		}
		else {
			configure.fullScreen=false;
		}

		resolution.resolutionX = PlayerPrefs.GetInt("resolutionX");
		resolution.resolutionY = PlayerPrefs.GetInt("resolutionY");
		if (resolution.resolutionX==0 ) {
			resolution.resolutionX=1280;
			resolution.resolutionY=720;
		}
		Screen.SetResolution (resolution.resolutionX, resolution.resolutionY, configure.fullScreen);

	}
	
	// Update is called once per frame
	void Update () {
		//Screen.SetResolution (resolution.resolutionX, resolution.resolutionY, configure.isFullScreen);
		if (Time.time > 2.9 && Time.time <4.9 && GetComponent<Light>().intensity < 3.5) {
			GetComponent<Light>().intensity += 0.2f;
		}
		/*if (light.intensity >= intensity) {
			light.intensity -= 0.4f;
			intensity-=0.5f;
		}*/

	}
}
