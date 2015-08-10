using UnityEngine;
using System.Collections;

public class movie : MonoBehaviour {
	public MovieTexture movTexture;
	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().material.mainTexture = movTexture;
		movTexture.loop = true;
		movTexture.Play();  
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
