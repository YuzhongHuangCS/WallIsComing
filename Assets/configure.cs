using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class configure : MonoBehaviour {
	public static float lastVolume=5f;
	public static int lastAnti;
	public static int lastQuality;
	public static int defaultResolution = 2;
	public static int xwidth=1280 ;
	public static int ywidth=720 ;
	public static int isFullScreen;
	public static bool fullScreen=false;
	public static bool fullScreen2=false;
	public Texture2D sliderBackground = null;
	public Texture2D sliderBackground2 = null;
	public Texture2D thumbBackground = null;
	public Texture2D[] windowBackground = null;
	public static int id = 0;
	public static int quality = 4;
	public static int AntiAliasing = 2;
	public static Vector2 NativeResolution  = new Vector2(1280, 720);
	private static float _guiScaleFactor = -1.0f;
	private static Vector3 _offset = Vector3.zero;
	private bool _didResizeUI;

	static List<Matrix4x4> stack = new List<Matrix4x4> ();

	// Use this for initialization
	void Start () {
		resolution.resolutionX = PlayerPrefs.GetInt("resolutionX");
		resolution.resolutionY = PlayerPrefs.GetInt("resolutionY");
		quality = PlayerPrefs.GetInt ("lastQuality")-1;
		AntiAliasing = PlayerPrefs.GetInt ("lastAnti") - 1;
		configure.isFullScreen = PlayerPrefs.GetInt ("isFullScreen");
		if (configure.isFullScreen == 0) {
			fullScreen2=true;
		}
		else {
			fullScreen2=false;
		}


		switch (resolution.resolutionX) {
		case (1024):
			defaultResolution=0;
			break;
		case(1136):
			defaultResolution=1;
			break;
		case(1280):
			defaultResolution=2;
			break;
		case(1600):
			defaultResolution=3;
			break;
		case(1960):
			defaultResolution=4;
			break;
		default:
			break;
		}
		switch (fullScreen2) {
		case(false):
			id=0;
			break;
		case(true):
			id=1;
			break;
		default:
			break;
		}
	}

	public void BeginUIResizing()
	{
		Vector2 nativeSize = NativeResolution;
		
		 _didResizeUI = true;
		
		stack.Add (GUI.matrix);
		Matrix4x4 m = new Matrix4x4();
		var w = (float)Screen.width;
		var h = (float)Screen.height;
		var aspect = w / h;
		var offset = Vector3.zero;
		if(aspect < (nativeSize.x/nativeSize.y)) 
		{ 
			//screen is taller
			_guiScaleFactor = (Screen.width/nativeSize.x);
			offset.y += (Screen.height-(nativeSize.y*_guiScaleFactor))*0.5f;
		} 
		else 
		{ 
			// screen is wider
			_guiScaleFactor = (Screen.height/nativeSize.y);
			_offset.x += (Screen.width-(nativeSize.x*_guiScaleFactor))*0.5f;
		}
		
		m.SetTRS(offset,Quaternion.identity,Vector3.one*_guiScaleFactor);
		GUI.matrix *= m;	
	}
	
	public void EndUIResizing()
	{
		GUI.matrix = stack[stack.Count - 1];
		stack.RemoveAt (stack.Count - 1);
		_didResizeUI = false;
	}


	void OnGUI(){
		BeginUIResizing();
		GUIStyle style = new GUIStyle ();
		style.normal.background = null;    
		style.normal.textColor = new Color (1, 1, 1);   
		style.fontSize = 40; 
		style.fontStyle = FontStyle.Bold;
		string str = (volume.MainVolume).ToString();
		string str2 = "X" + QualitySettings.antiAliasing.ToString ();
		string str3="Beautiful";
		string str4=resolution.resolutionX + "*" + resolution.resolutionY;

		GUIStyle sliderStyle = new GUIStyle ();
		sliderStyle.normal.background = sliderBackground;

		GUIStyle style2 = new GUIStyle ();
		style2.normal.background = null;    
		style2.normal.textColor = new Color (1, 1, 1);   
		style2.fontSize = 30; 
		//style.fontStyle = FontStyle.Bold;

		GUIStyle style3 = new GUIStyle ();
		style3.normal.background = null;    
		style3.normal.textColor = new Color (1, 1, 1);   
		style3.fontSize = 35; 
		style3.fontStyle = FontStyle.Bold;

		GUIStyle style4 = new GUIStyle ();
		style4.normal.background = windowBackground[id];    

		
		GUIStyle thumbStyle = new GUIStyle ();
		thumbStyle.normal.background = thumbBackground;
		thumbStyle.fixedHeight = 30;
		thumbStyle.fixedWidth = 30;

		GUIStyle sliderStyle2 = new GUIStyle();
		sliderStyle2.normal.background = sliderBackground2;





	    GUI.Label(new Rect(480, 108, 470, 50),"",sliderStyle2);
		volume.MainVolume=(int)GUI.HorizontalSlider(new Rect(500, 117, 400, 60), volume.MainVolume, 0.0f, 10f, sliderStyle,thumbStyle);
		lastVolume = volume.MainVolume;

		GUI.Label(new Rect(480, 208, 470, 50),"",sliderStyle2);
		AntiAliasing = (int)GUI.HorizontalSlider(new Rect(500, 220, 400, 60), AntiAliasing, 0.0f, 3.0f, sliderStyle,thumbStyle);
		lastAnti = (AntiAliasing+1);
		if (AntiAliasing >=1) {
			QualitySettings.antiAliasing = (int)Mathf.Pow (2, AntiAliasing);
		}
		if (AntiAliasing < 1) {
			QualitySettings.antiAliasing = 0;
			str2="Disabled";
		}


		GUI.Label(new Rect(480, 308, 470, 50),"",sliderStyle2);
		quality = (int)GUI.HorizontalSlider(new Rect(500, 320, 400, 60), quality, 0.0f, 5.0f, sliderStyle,thumbStyle);
		QualitySettings.SetQualityLevel ((int)quality);
		lastQuality = (quality + 1);

		GUI.Label(new Rect(480, 408, 470, 50),"",sliderStyle2);
		defaultResolution=(int)GUI.HorizontalSlider(new Rect(500, 420, 400, 60), defaultResolution, 0.0f, 4.0f, sliderStyle,thumbStyle);
		switch (defaultResolution) {
		case 0:
			xwidth=1024;
			ywidth=576;
			str4="1024*576";
			break;
		case 1:
			xwidth=1136;
			ywidth=640;
			str4="1136*640";
			break;
		case 2:
			xwidth=1280;
			ywidth=720;
			str4="1280*720";
			break;
		case 3:
			xwidth=1600;
			ywidth=900;
			str4="1600*900";
			break;
		case 4:
			xwidth=1920;
			ywidth=1080;
			str4="1920*1080";
			break;
		}
		//Screen.SetResolution (xwidth, ywidth, isFullScreen);

		switch (quality) {
		case 0:
			str3 = "Fastest";
			break;
		case 1:
			str3 = "Fast";
			break;
		case 2:
			str3 = "Simple";
			break;
		case 3:
			str3 = "Good";
			break;
		case 4:
			str3 = "Beautiful";
			break;
		case 5:
			str3 = "Fantastic";
			break;
		}
		GUI.Label (new Rect (960, 115, 400, 60), str, style2);
		GUI.Label (new Rect (960, 215, 500, 60), str2, style2);	
		GUI.Label (new Rect (960, 315, 600, 60), str3, style2);		
		GUI.Label (new Rect (960, 415, 600, 60), str4, style2);
		GUI.Label (new Rect (260, 110, 400, 60), "Volume", style3);
		GUI.Label (new Rect (260, 210, 400, 60), "Antialiasing", style3);
		GUI.Label (new Rect (260, 310, 400, 60), "Quality", style3);
		GUI.Label (new Rect (260, 410, 400, 60), "Resolution", style3);
		GUI.Label (new Rect (260, 510, 400, 60), "Windowed", style3);
		if (GUI.Button (new Rect (500, 500, 60, 60), "", style4)) {
			id=1-id;

			isFullScreen=1-isFullScreen;

		}



		EndUIResizing();
	}
	// Update is called once per frame
	void Update () {
		PlayerPrefs.SetInt("resolutionX", xwidth);
		PlayerPrefs.SetInt("resolutionY", ywidth);
		PlayerPrefs.SetInt ("isFullScreen", isFullScreen);
		PlayerPrefs.SetFloat ("lastVolume", lastVolume);
		PlayerPrefs.SetInt ("lastAnti", lastAnti);
		PlayerPrefs.SetInt("lastQuality", lastQuality);

	}
}
