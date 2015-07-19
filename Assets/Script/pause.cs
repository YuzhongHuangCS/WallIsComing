using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class pause : MonoBehaviour , IPointerClickHandler{

	// Use this for initialization
	void Start () {

	}

	public void OnPointerClick (PointerEventData data) {

			// reload the scene
			Time.timeScale = 0;


	}

	// Update is called once per frame
	void Update () {
	
	}
}
