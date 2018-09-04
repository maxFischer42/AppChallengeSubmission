using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RTS_Cam;
using UnityEngine.UI;

public class displayCannonButtons : MonoBehaviour {

    public Canvas unitCanvas;
    public Transform unitToZoom;
    public RTS_Camera cam;
    public bool isSelected;

    private void Awake()
    {
        cam = Camera.main.GetComponent<RTS_Camera>();
        unitToZoom = gameObject.transform;
    }

	

    public void OnMouseDown()
    {
        switch (isSelected)
        {
            case false:
                cam.SetTarget(unitToZoom);
                isSelected = true;
                unitCanvas.enabled = true;
                break;
            case true:
                cam.SetTarget(null);
                isSelected = false;
                unitCanvas.enabled = false;
                break;
        }
    }
}
