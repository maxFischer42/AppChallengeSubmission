using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkExist : MonoBehaviour {

    public checkMe check;
    public Canvas battleCanvas;

	// Use this for initialization
	void Start () {
        if(check.truefalse)
        {
            Destroy(gameObject);
        }
        else
        {
            
            check.truefalse = true;           
        }
	}



}
