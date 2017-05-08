using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadingScene : MonoBehaviour {

	public Texture2D fadeOutTexture;	// the texutre that will overlay the scree. This can be a black image or a loading graphic
	public float fadeSpeed = 0.8f;		// the fading speed

	private int drawDepth = -1000;		// the texture's order in the draw hierarachy
	private float alpha = 1.0f;
	private int fadeDir = -1;

	void OnGUI(){
		alpha += fadeDir * fadeSpeed * Time.deltaTime;

		alpha = Mathf.Clamp01 (alpha);

		GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alpha);
		GUI.depth = drawDepth;
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fadeOutTexture);
	}

	public float BeginFade (int direction) {
		fadeDir = direction;
		return (fadeSpeed);
	}

	//OnLevelWasLoaded is called when a level is loaded. It takes
	void OnLevelWasLoaded () {
		//alpha = 1;		// use this if the alpha is not set to 1 by default
		BeginFade (-1);
	}

}
