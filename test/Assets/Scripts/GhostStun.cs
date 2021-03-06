﻿using UnityEngine;
using System.Collections;

public class GhostStun : MonoBehaviour {

	
	bool lightcheck;

	Flashlight flash;
	
	public GameObject Ghost;

	public GameObject Flashlight;

	void Start () {
		flash = gameObject.GetComponentInChildren<Light>().GetComponentInChildren<Flashlight>();
		print("Obj:" + flash);
		flash.setLightOn();
		print("Start" + flash.isLightOn());
		
	}
	
	
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		print("other.gameObject.name");
		print ("Collider" + flash);
		if(other.gameObject.name == "Ghost" && flash == true ){
			print("Ghost is stunned!");
			other.GetComponent<GhostAI>().moveSpeed = 0f;
			StartCoroutine(Wait(5, other));
		}
		else{
			print("collider active");
		}
	}

	IEnumerator Wait(float time, Collider other){
		yield return new WaitForSeconds(time);
		other.gameObject.GetComponent<GhostAI>().moveSpeed = 5f;
		print("Ghost is unstunned!");
	}
}