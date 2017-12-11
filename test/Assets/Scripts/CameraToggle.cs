using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraToggle : MonoBehaviour {

	public bool cameraOn = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.P) && cameraOn) {
		print("Camera off");
		cameraOn = false;
		
		}
		else if (Input.GetKeyUp (KeyCode.P) && !cameraOn){
			print("Camera on");
			cameraOn = true;
		}
	
	}
}