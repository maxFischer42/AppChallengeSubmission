using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonAim : MonoBehaviour {

	public float rotationSpeed = 2.0f;
	public float aimVerticalSpeed = 1.0f;

    private Transform turretTransform;



	// Use this for initialization
	void Start ()
	{
		turretTransform = transform.parent.GetComponent<Transform>();
	}
	
	//Press button to rotate the turret clockwise
	public void rotateClockwise ()
	{		
		float i = Mathf.Abs(rotationSpeed * Time.deltaTime);
		rotateHorizontal(i);
	}
	
	//Press button to rotate the turret counter-clockwise
	public void rotateCounterClockwise ()
	{
		float i = Mathf.Abs(rotationSpeed * Time.deltaTime);
		i *= -1;
		rotateHorizontal(i);
	}
	
    //Take the direction variable and use it to rotate the turret
	void rotateHorizontal(float direction)
	{
        float x;
        x = direction;
        turretTransform.rotation = Quaternion.Euler(x, 0, 0);
	}


	
	
}
