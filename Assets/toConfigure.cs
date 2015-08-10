using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class toConfigure : MonoBehaviour ,IPointerClickHandler,IPointerEnterHandler{
	public  AudioClip A= null;
	public  AudioClip B=null;
	private GameObject confCanvas;
	public static GameObject mainCamera;
	//private GameObject Canvas;
	// Use this for initialization
	void Start () {
		confCanvas = GameObject.Find ("confCanvas");
		mainCamera = GameObject.Find ("Main Camera");
		//Canvas = GameObject.Find ("Canvas");

	}
	public void OnPointerEnter (PointerEventData data) {
		GetComponent<AudioSource>().PlayOneShot(A,0.5f);
		
	}
	public void OnPointerClick (PointerEventData data) {
		GetComponent<AudioSource>().PlayOneShot (B, 0.5f);
		confCanvas.SetActiveRecursively(true);
		//Camera2.SetActiveRecursively(true);
		//Canvas.SetActiveRecursively(false);
		mainCamera.transform.position = new Vector3(0, 100, -26.7f);
		mainCamera.transform.Rotate(-90, 0, 0);
	}
	// Update is called once per frame
	void Update () {
		GetComponent<AudioSource>().volume = volume.MainVolume/20f;
	}
}
