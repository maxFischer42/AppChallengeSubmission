using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateSky : MonoBehaviour {

    public float speed;
    public Transform lightSource;
	
	// Update is called once per frame
	void Update () {
        lightSource.Rotate(Vector3.right * Time.timeScale * speed, Space.World);
	}
}
