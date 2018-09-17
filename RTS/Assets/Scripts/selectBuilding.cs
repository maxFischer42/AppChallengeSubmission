using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectBuilding : MonoBehaviour {

    [Header("Reset Settings")]
    public GameObject MainCamera;
    public GameObject NewCamera;
    public GameObject CanvasToDisable;

    [Header("Upgrade Settings")]
    public Canvas Canvas;
    public bool[] hasBoughtBuilding;
    public int[] buildingID;
    public Sprite[] buildingImage;

    public dontSelect dontSel;



	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void Call()
    {
        MainCamera.SetActive(false);
        NewCamera.SetActive(true);
        CanvasToDisable.SetActive(false);
        Canvas.enabled = true;
        dontSel.boolean = true;
    }

    public void Return()
    {
        MainCamera.SetActive(true);
        NewCamera.SetActive(false);
        CanvasToDisable.SetActive(true);
        Canvas.enabled = false;
        dontSel.boolean = false;
    }
}
