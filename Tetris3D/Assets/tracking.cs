using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tracking : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	float distance = 3;

	void Update() {
		
		transform.position = transform.position + Camera.main.transform.forward * distance;
	}
}
