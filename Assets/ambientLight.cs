using UnityEngine;
using System.Collections;

public class ambientLight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		RenderSettings.ambientLight = new Color (0.15f, 0.15f, 0.15f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
