using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public float moveSpeed;
	public float turnSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Move Forward, Back and Rotate Left and Right.
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
	}
}