using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class backMenu : MonoBehaviour ,IPointerClickHandler,IPointerEnterHandler{
	public  AudioClip A= null;
	public  AudioClip B=null;
	private GameObject canvas;
	//private  GameObject Camera;
	//private GameObject Canvas1;
	// Use this for initialization
	void Start () {
		canvas = GameObject.Find ("backText");
		//Camera = GameObject.Find ("Camera");
		//Canvas1 = GameObject.Find ("Canvas1");
	}
	public void OnPointerEnter (PointerEventData data) {
		GetComponent<AudioSource>().PlayOneShot(A,0.5f);
		
	}
	public void OnPointerClick (PointerEventData data) {
		GetComponent<AudioSource>().PlayOneShot (B, 0.5f);
		canvas.SetActiveRecursively(false);
		//Camera.SetActiveRecursively(false);
		//Canvas1.SetActiveRecursively(true);
		toConfigure.mainCamera.transform.position = new Vector3(0, 34, 0);
		toConfigure.mainCamera.transform.Rotate(90, 0, 0);
	}
	// Update is called once per frame
	void Update () {
		GetComponent<AudioSource>().volume = volume.MainVolume/20f;
	}
}