using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getUnitsInCamera : MonoBehaviour {

    public GameObject[] units;
    public Canvas allUnits;
	

	// Update is called once per frame
	void Update ()
    {
		if(Input.GetMouseButtonDown(1))
        {
            units = GameObject.FindGameObjectsWithTag("Player");
            allUnits.GetComponent<moveGroup>().units = units;
            allUnits.enabled = true;
            

        }
	}
}
