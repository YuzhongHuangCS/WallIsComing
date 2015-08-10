using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class gameToConfigure : MonoBehaviour,IPointerClickHandler,IPointerEnterHandler {
	public  AudioClip A= null;
	public  AudioClip B=null;
	
	void Start () {

	}
	public void OnPointerEnter (PointerEventData data) {
		GetComponent<AudioSource>().PlayOneShot(A,0.5f);
		
	}
	public void OnPointerClick (PointerEventData data) {
		GetComponent<AudioSource>().PlayOneShot (B, 0.5f);
		//GameObject.Find ("pauseCanvas").SetActive (false);
		GameObject.Find ("Canvas").SetActive (false);
		GameObject.Find("pauseCanvas").GetComponent<Canvas>().enabled=false;
		GameObject.Find ("configureScene").SetActiveRecursively (true);
		GameObject.Find ("Main Camera").SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<AudioSource>().volume = volume.MainVolume/20f;
	}
}