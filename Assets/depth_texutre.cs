using UnityEngine;
using System.Collections;

public class depth_texutre : MonoBehaviour {
	public void Awake() {		
		GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
	}
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
