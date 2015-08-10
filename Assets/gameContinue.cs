using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class gameContinue : MonoBehaviour ,IPointerClickHandler,IPointerEnterHandler{
	public  AudioClip A= null;
	public  AudioClip B=null;
	public Image image;
	public Sprite stop;
	// Use this for initialization
	void Start () {

	}
	
	public void OnPointerClick (PointerEventData data) {
		GetComponent<AudioSource>().PlayOneShot (B, 0.5f);
		pause.i = !pause.i; 
		if (pause.i) {  
			image.overrideSprite = stop;
			
		}  
		GameObject.Find("pauseCanvas").GetComponent<Canvas>().enabled=false;
	}

	public void OnPointerEnter (PointerEventData data) {
		GetComponent<AudioSource>().PlayOneShot(A,0.5f);
		
	}

	// Update is called once per frame
	void Update () {
		GetComponent<AudioSource>().volume = volume.MainVolume/20f;
		if (pause.i) {
			Time.timeScale = 1;
			//GameObject.Find("Main Camera").GetComponent<KeyboardControl>().enabled=true;
		}
	}
}
