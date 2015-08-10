using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class toGame : MonoBehaviour ,IPointerClickHandler,IPointerEnterHandler{
	public  AudioClip A= null;
	public  AudioClip B=null;
	// Use this for initialization
	void Start () {
		pause.i = true;
	}
	public void OnPointerEnter (PointerEventData data) {
		GetComponent<AudioSource>().PlayOneShot(A,0.5f);
		
	}
	public void OnPointerClick (PointerEventData data) {
		GetComponent<AudioSource>().PlayOneShot (B, 0.5f);
		Application.LoadLevel("game");
		
	}
	// Update is called once per frame
	void Update () {
		GetComponent<AudioSource>().volume = volume.MainVolume/20f;
	}
}
