using UnityEngine;
using System.Collections;

public class resolution : MonoBehaviour {
	public static int resolutionX;
	public static int resolutionY;
	// Use this for initialization
	void Start () {
		Screen.SetResolution (resolutionX, resolutionY, configure.fullScreen);
	}
	
	// Update is called once per frame
	void Update () {

		//Screen.SetResolution (resolutionX, resolutionY, configure.isFullScreen);
	}
}
