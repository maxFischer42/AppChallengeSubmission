using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boxSelectUnits : MonoBehaviour {

    public bool enable = true;
    public GameObject[] unitArray;
    public GameObject cubeScroll;
    private GameObject instantiatedCube = null;
    public GameObject boxObj;
    public bool isScrolling = false;
    public boxSelectUnits par;


    // Update is called once per frame
    void Update ()
    {
        if (!enable)
            return;
        Vector3 mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        if (Input.GetAxisRaw("Fire2") > 0 && isScrolling != true)
        {
            instantiatedCube = (GameObject)Instantiate(cubeScroll, Vector3.zero, cubeScroll.transform.rotation);
            instantiatedCube.GetComponent<RectTransform>().anchoredPosition = mousePos;
            isScrolling = true;
        }
        else if(Input.GetAxisRaw("Fire2") > 0 && isScrolling == true)
        {
            instantiatedCube.GetComponent<RectTransform>().anchoredPosition = mousePos;
        }
        else if(Input.GetAxisRaw("Fire2") == 0 && isScrolling == true)
        {
            GameObject aaa = (GameObject)Instantiate(boxObj, instantiatedCube.transform.position, boxObj.transform.rotation);
            Destroy(aaa, 1f);
        }
        

	}


}
