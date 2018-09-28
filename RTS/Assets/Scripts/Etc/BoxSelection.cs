using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RTS_Cam;

public class BoxSelection : MonoBehaviour {


    private RTS_Camera cameraScript;

    public RectTransform box_obj;
    public Rect m_box;

    //how many frames does the m1 need to be down for the script to consider it "held down"
    public int framesUntilHolding = 30;

    //used to determine if the mouse is being held.
    public int timer = 0;

    private bool hasOriginPoint;
    public Vector3 originPoint;

    public bool holdingMouseButton;





    void Start()
    {
        cameraScript = Camera.main.GetComponent<RTS_Camera>();
    }










    void Update()
    {
        if (Input.GetMouseButtonUp(0))
            ResetValues();



        if (holdingMouseButton)
        {
            if(hasOriginPoint)
            {
              ////////////////
            }
            else
            {
                originPoint = GetOrigin();
                SetOrigin();
            }
        }
        else
        {
            bool mouseDown = CheckMouseInput();
            if (mouseDown)
            {
                IncreaseTimer();
                if (CheckTimer())
                {
                    holdingMouseButton = true;
                }
            }
        }


    }









    void SetOrigin()
    {
        Debug.Log("Origin set");
        m_box = new Rect(new Vector2(originPoint.x,originPoint.y),new Vector2(1,1));
        box_obj.position = originPoint;
    }

    Vector3 GetOrigin()
    {
        Debug.Log("Origin obtained");
        Vector3 origin = Vector3.zero;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 999999f))
        {
            origin = hit.point;
        }



        hasOriginPoint = true;
        return origin;
    }

    void FreezeCamera()
    {
        Debug.Log("Camera Frozen");
        cameraScript.enabled = false;
    }









    //Change any values in the script back to their default
    void ResetValues()
    {
        Debug.Log("------------------------------RESET-----------------------------------");        
        holdingMouseButton = false;
        //cameraScript.enabled = true;
        hasOriginPoint = false;
        originPoint = Vector3.zero;
        timer = 0;
    }





    bool CheckMouseInput()
    {
        if(Input.GetMouseButton(0))
        {
            Debug.Log("Mouse button down");
            return true;
        }
        return false;

    }


    bool CheckTimer()
    {
        if(timer == framesUntilHolding)
        {
            Debug.Log("Has held down");
            holdingMouseButton = true;
            timer = 0;
            return true;
        }
        return false;
    }



    void IncreaseTimer()
    {
        timer++;
        return;
    }





}
