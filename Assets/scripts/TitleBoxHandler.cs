using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleBoxHandler : MonoBehaviour {

	public GameObject titleBox;

	// Use this for initialization
	void Awake () {
		titleBox.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		titleBox.SetActive (Manage_Text_Information.detected);
	}
}
