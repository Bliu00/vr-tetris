using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotation : MonoBehaviour {

	Rigidbody rb;

	void Awake(){
		rb = GetComponent<Rigidbody> ();
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			transform.Rotate (0, 24, 0);

		}
	}

}