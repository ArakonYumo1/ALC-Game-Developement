using UnityEngine;
using System.Collections;

public class GhostAI : MonoBehaviour {

	public float moveSpeed;
	public Transform target;
	public int damage;



	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.name == "player"){
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}
	}

}