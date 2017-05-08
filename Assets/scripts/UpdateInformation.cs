using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpdateInformation : MonoBehaviour {

	Text InformationText;

	// Use this for initialization
	void Awake () {
		InformationText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		InformationText.text = Manage_Text_Information.infoText;
	}
}