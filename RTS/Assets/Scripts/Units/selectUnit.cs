using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RTS_Cam;

public class selectUnit : MonoBehaviour {

    public RTS_Camera cam;
    public Transform unitToZoom;
    public Canvas unitCanvas;
    public bool isSelected;

    private void Awake()
    {
        cam = Camera.main.GetComponent<RTS_Camera>();

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
