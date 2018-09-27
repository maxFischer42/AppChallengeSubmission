using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getUnitsInCamera : MonoBehaviour {

    public GameObject[] units;
    public Canvas allUnits;
	

	// Update is called once per frame
	void Update ()
    {
		if(Input.GetButtonDown("Jump"))
        {
            units = GameObject.FindGameObjectsWithTag("Player");
            
            allUnits.enabled = true;
            allUnits.GetComponent<moveGroup>().enabled = true;
            allUnits.GetComponent<moveGroup>().units = units;


        }
	}
}
