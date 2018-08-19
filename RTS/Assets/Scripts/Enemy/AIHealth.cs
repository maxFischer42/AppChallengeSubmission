using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIHealth : MonoBehaviour {

    public int HP = 10;
	
	// Update is called once per frame
	void Update () {
		if(HP <= 0)
        {
            Destroy(gameObject);
        }
	}
}
