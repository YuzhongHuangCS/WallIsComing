using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnimationControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void TurnOff() {
		GetComponent<Animator>().enabled = false;
		GetComponent<RunControl>().enabled = true;
		GameObject.Find("Player").GetComponent<RunControl>().enabled = true;
		GameObject.Find("Storm2_peak").GetComponent<ParticleSystem>().enableEmission = false;
		GameObject.Find("Storm_Ground").GetComponent<ParticleSystem>().enableEmission = false;

		GameObject.Find("Slider").GetComponent<Slider>().value = 100;
		Invoke("TurnonCube", 3.5f);
	}

	void TurnonCube() {
		GameObject.Find("Cube").GetComponent<MeshRenderer>().enabled = true;
	}
}
