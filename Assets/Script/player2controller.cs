using UnityEngine;
using System.Collections;

public class player2controller : MonoBehaviour {
		// Use this for initialization

		bool move = true;
		float x =35.35f;
		float y =0.2f;
		float z =-2.44f;
	void Start () {
			transform.position = new Vector3(x,y,z);
		}

		// Update is called once per frame
		void Update () {
			float speed = 3.0f*Time.deltaTime;
			if (move == true) {
				if(transform.position.x > 52.5f){
					move = false;
					transform.Rotate (0f, 180f, 0f);
				} else {
					transform.Translate (new Vector3 (0, 0, speed));

				}
			} 
			else if(move ==false){
				if (transform.position.x > 37.35f) {
					transform.Translate (new Vector3 (0, 0, speed));

				} else {
					move = true;
					transform.Rotate (0f, 180f, 0f);
				}
			} 
		}
	}
