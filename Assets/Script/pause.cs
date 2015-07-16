using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;  




public class pause : MonoBehaviour , IPointerClickHandler{

	// Use this for initialization
	void Start () {

	}

	bool i=true;

	void OnPressed ()    
	{    
		i = !i;    
	}   


	void OnClick () {  
		if (this.i) {  
			object obj = Resources.Load("health", typeof(Sprite));
			Sprite sp = obj as Sprite;

			this.i = false;  
		}  
		else{  
			object obj = Resources.Load("source", typeof(Sprite));
			Sprite sp = obj as Sprite;
 
			this.i = true;  
		}  
	}  

	public void OnPointerClick (PointerEventData data) {

			// reload the scene
		OnPressed ();

	}

	// Update is called once per frame
	void Update () {
	
		if (i) {
			Time.timeScale = 1;
		}
		else {
			Time.timeScale=0;
		}
	}
}


