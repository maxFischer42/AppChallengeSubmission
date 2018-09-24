using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOnOnActive : MonoBehaviour {

    public GameObject objectToTurn;

	// Use this for initialization
	void Awake () {
        objectToTurn.SetActive(true);
	}
	

}
