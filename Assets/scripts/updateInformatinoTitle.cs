using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateInformatinoTitle : MonoBehaviour {

	Text InformationTitle;

	// Use this for initialization
	void Awake () {
		InformationTitle = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		InformationTitle.text = Manage_Text_Information.infoTitle;
	}
}