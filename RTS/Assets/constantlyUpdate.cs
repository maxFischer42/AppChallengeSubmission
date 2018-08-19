using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class constantlyUpdate : MonoBehaviour {

    public GameObject prefab;
	
	// Update is called once per frame
	void Update () {
        prefab = gameObject;
	}
}
