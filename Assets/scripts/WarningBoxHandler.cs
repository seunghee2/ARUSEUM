using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningBoxHandler : MonoBehaviour {

	public GameObject warningBox;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		warningBox.SetActive (!Manage_Text_Information.detected);
	}
}
