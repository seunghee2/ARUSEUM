﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScript : MonoBehaviour {
	public float delayTime = 3;

	IEnumerator Start () {
		yield return new WaitForSeconds (delayTime);

		Application.LoadLevel ("arMain");
	}

}
