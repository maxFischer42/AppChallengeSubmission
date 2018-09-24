using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkdiff : MonoBehaviour {

    public changeDifficulty diff;
    public int myDiff;

	// Use this for initialization
	void Start () {
        diff = GameObject.FindObjectOfType<changeDifficulty>().GetComponent<changeDifficulty>();
        if(myDiff != diff.currentDifficulty)
        {
            Destroy(gameObject);
        }
    }
	
	
}
