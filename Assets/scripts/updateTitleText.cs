using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateTitleText : MonoBehaviour {

	Text TitleText;

	// Use this for initialization
	void Awake () {
		TitleText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		TitleText.text = Manage_Text_Information.infoTitle;
	}
}
