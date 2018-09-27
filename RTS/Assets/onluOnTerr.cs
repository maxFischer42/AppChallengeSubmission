using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onluOnTerr : MonoBehaviour {

	
	
	
	// Update is called once per frame
	void Update () {
	    if(SceneManager.GetActiveScene().name == "Territories")
        {
            GetComponent<Camera>().enabled = true;
        }
        else
        {
            GetComponent<Camera>().enabled = false;
        }
	}
}
