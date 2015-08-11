using UnityEngine;
using System.Collections;

[AddComponentMenu("ShowFPS")]
public class ShowFPS : MonoBehaviour {
	private static int count = 0;
	private static float milliSecond = 0;
	private static float fps = 0;
	private static float deltaTime = 0.0f;

	void OnGUI() {
		if (++count > 10) {
			count = 0;
			milliSecond = deltaTime * 1000.0f;
			fps = 1.0f / deltaTime;
		}
		string text = string.Format("Render time: {0:0.0}ms FPS: {1:0.}", milliSecond, fps);
		GUILayout.Label(text);
	}

	void Update() {
		deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
	}
}
