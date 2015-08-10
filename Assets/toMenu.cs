using UnityEngine;
using System.Collections;

public class toMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	void change(){
		StartCoroutine (Func ());    
		Application.LoadLevel ("game");
	}
	IEnumerator Func ()
	{

		yield return new WaitForSeconds(5f);
		
	}

	// Update is called once per frame
	void Update () {

	}
}
