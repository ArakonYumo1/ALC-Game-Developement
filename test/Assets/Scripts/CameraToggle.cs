using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CameraToggle : MonoBehaviour {

	public bool cameraOn = true;

	Camera camera;

	// Use this for initialization
	void Start () {
		camera = GetComponent<Camera> ();
		cameraOn = true;
		camera.enabled = true;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Q) && cameraOn) {
		print("Camera off");
		cameraOn = false;
		camera.enabled = false;
		
		}
		else if (Input.GetKeyUp (KeyCode.Q) && !cameraOn){
			print("Camera on");
			cameraOn = true;
			camera.enabled = true;
		}
	
	}
}