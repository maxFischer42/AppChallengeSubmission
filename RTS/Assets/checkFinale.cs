using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkFinale : MonoBehaviour {

    public purchases data;
	
	// Update is called once per frame
	void Start ()
    {
        data = GameObject.FindObjectOfType<purchases>().GetComponent<purchases>();
        if(!data.RCFoodProcCentre)
        {
            gameObject.SetActive(false);
        }

	}
}
