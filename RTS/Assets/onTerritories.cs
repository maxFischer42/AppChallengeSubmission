using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTerritories : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        Camera[] cams = GameObject.FindObjectsOfType<Camera>();
        for(int i = 0; i < cams.Length; i++)
        {
            if(cams[i].name != "MainCamerA")
            {
                cams[i].gameObject.SetActive(false);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
