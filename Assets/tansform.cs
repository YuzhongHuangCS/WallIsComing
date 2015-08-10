using UnityEngine;
using System.Collections;

public class tansform : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (Time.time>2.5){
		transform.Translate(Vector3.right * Time.deltaTime*(-100));
		}
	}
}
