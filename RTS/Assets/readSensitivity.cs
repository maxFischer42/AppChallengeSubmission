using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RTS_Cam;

public class readSensitivity : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
        GetComponent<RTS_Camera>().scrollWheelZoomingSensitivity = PlayerPrefs.GetInt("Sensitivity");
        GetComponent<RTS_Camera>().mouseRotationSpeed = PlayerPrefs.GetInt("Sensitivity");
        GetComponent<RTS_Camera>().panningSpeed = PlayerPrefs.GetInt("Sensitivity");
    }
}
