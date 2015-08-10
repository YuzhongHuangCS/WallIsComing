using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;  
using UnityEngine.UI;




public class pause : MonoBehaviour , IPointerClickHandler{
	public static bool health=true;
	public Image image;
	public Sprite stop;
	public Sprite start;
	public static bool i=true;
	// Use this for initialization
	void Start () {
		image.overrideSprite = stop;
	}

	public void OnPointerClick (PointerEventData data) {

		i = !i; 
		health=!health;
		if (i) {  
			image.overrideSprite = stop;
			GameObject.Find("pauseCanvas").GetComponent<Canvas>().enabled=false;

 
		}  
		else{  
			image.overrideSprite = start;
			GameObject.Find("pauseCanvas").GetComponent<Canvas>().enabled=true;

		}  


	}

	// Update is called once per frame
	void Update () {
	
		if (i) {
			Time.timeScale = 1;
			//GameObject.Find("Main Camera").GetComponent<KeyboardControl>().enabled=true;
			//GameObject.Find("Main Camera").GetComponent<AudioListener>().aud;
			//GameObject.Find("windSound").GetComponent<AudioListener>().;
			//AudioListener.pause=false;
		}
		else {
			Time.timeScale=0;
			//GameObject.Find("Main Camera").GetComponent<KeyboardControl>().enabled=false;
			//AudioListener.pause=true;
		}
	}
}


