using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonAim : MonoBehaviour {

	public float rotationSpeed = 2.0f;
	public float aimVerticalSpeed = 1.0f;
	
	private RigidBody2d _rigidbody;




	// Use this for initialization
	void Start ()
	{
		_rigidbody = GetComponent<RigidBody2d>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	//Press button to rotate the turret clockwise
	public void rotateClockwise ()
	{		
		float i = Math.abs(rotationSpeed * Time.deltaTime);
		rotateHorizontal(i);
	}
	
	//Press button to rotate the turret counter-clockwise
	public void rotateCounterClockwise ()
	{
		float i = Math.abs(rotationSpeed * Time.deltaTime);
		i *= -1;
		rotateHorizontal(i);
	}
	
	void rotateHorizontal(float direction)
	{
		
	}


	
	
}
