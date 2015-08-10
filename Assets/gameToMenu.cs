using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class gameToMenu : MonoBehaviour,IPointerClickHandler,IPointerEnterHandler {
	public  AudioClip A= null;
	public  AudioClip B=null;

	void Start () {

		//Camera = GameObject.Find ("Camera");
		//Canvas1 = GameObject.Find ("Canvas1");
	}
	public void OnPointerEnter (PointerEventData data) {
		GetComponent<AudioSource>().PlayOneShot(A,0.5f);
		
	}
	public void OnPointerClick (PointerEventData data) {
		GetComponent<AudioSource>().PlayOneShot (B, 0.5f);
		Application.LoadLevel("menu");
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<AudioSource>().volume = volume.MainVolume/20f;
	}
}
