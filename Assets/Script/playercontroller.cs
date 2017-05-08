using UnityEngine;
using System.Collections;

public class playercontroller : MonoBehaviour {
// Use this for initialization

	bool move = true;
	float x =52.0f;
	float y =0f;
	float z =-2.54f;
	void Start () {
		

		transform.position = new Vector3(x,y,z);
	}

	void Update () {
		float speed = 3.0f*Time.deltaTime;
		if (move == true) {
			if(transform.position.x < 37.5f){
				move = false;
				transform.Rotate (0f, 180f, 0f);
			} else {
				transform.Translate (new Vector3 (0, 0, speed));

			}
		} 
		else if(move ==false){
			if (transform.position.x < 52.35f) {
				transform.Translate (new Vector3 (0, 0, speed));

			} else {
				move = true;
				transform.Rotate (0f, 180f, 0f);
			}
		} 
	}
}
