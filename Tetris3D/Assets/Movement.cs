using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	private bool grounded;

	private double x0 = 12.125565617;
	private double z0 = 0;
	private float a0 = 0;

	private double x1 = 11.07725498;
	private double z1 = 4.931911854;
	private float a1 = 24;

	private double x2 = 8.113586775;
	private double z2 = 9.011051344;
	private float a2 = 48;

	private double x3 = 3.74005704;
	private double z3 = 11.53209819;
	private float a3 = 72;

	private double x4 = -1.26746674;
	private double z4 = 12.0591405;
	private float  a4 = 96;

	private double x5 = -6.062782809;
	private double z5 = 10.50104786;
	private float  a5 = 120;

	private double x6 = -9.809788651;
	private double z6 = 7.127228645;
	private float  a6 = 144;

	private double x7 = -11.86059292;
	private double z7 = 2.52104685;
	private float  a7 = 168;

	private double xN1 = 11.07725498;
	private double zN1 = -4.931911854;
	private float  aN1 = -24;

	private double xN2 = 8.113586775;
	private double zN2 = -9.011051344;
	private float  aN2 = -48;

	private double xN3 = 3.74005704;
	private double zN3= -11.53209819;
	private float  aN3 = -72;

	private double xN4 = -1.26746674;
	private double zN4 = -12.0591405;
	private float  aN4 = -96;

	private double xN5 = -6.062782809;
	private double zN5 = -10.50104786;
	private float aN5 = -120;

	private double xN6 = -9.809788651;
	private double zN6 = -7.127228645;
	private float aN6 = -144;

	private double xN7 = -11.86059292;
	private double zN7 = -2.52104685;
	private float aN7 = -168;

	// Use this for initialization

	void Start () {
		grounded = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void spawnRandomBlock(){
		
	}
		
}
