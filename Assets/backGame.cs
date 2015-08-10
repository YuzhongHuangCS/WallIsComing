using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class backGame : MonoBehaviour ,IPointerClickHandler,IPointerEnterHandler{
	public  AudioClip A= null;
	public  AudioClip B=null;
	public Image image;
	public Sprite stop;

	void Start () {

	}
	public void OnPointerEnter (PointerEventData data) {
		GetComponent<AudioSource>().PlayOneShot(A,0.5f);
		
	}
	public void OnPointerClick (PointerEventData data) {
		GetComponent<AudioSource>().PlayOneShot (B, 0.5f);
		GameObject.Find ("backText").SetActive (false);
		GameObject.Find ("cameraAndUI").SetActiveRecursively (true);
		GameObject.Find ("configureCamera").SetActive (false);
		GameObject.Find ("Plane0").SetActive (false);
		GameObject.Find ("Plane1").SetActive (false);
		GameObject.Find ("Plane2").SetActive (false);
		image.overrideSprite = stop;
		pause.i = !pause.i;


	}
	// Update is called once per frame
	void Update () {
		GetComponent<AudioSource>().volume = volume.MainVolume/20f;
	}
}