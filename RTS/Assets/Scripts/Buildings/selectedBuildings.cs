using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectedBuildings : MonoBehaviour {

    public bool isSelected;

    public Button Panel1;
    public Button Panel2;
    public Button Panel3;
    public Button Panel4;
    public Button Panel5;
    public Button Panel6;
    public Button Panel7;
    public Button Panel8;
    public Button Panel9;






	// Use this for initialization
	void Start ()
    {

        Panel1 = GameObject.Find("Up1").GetComponent<Button>();
        Panel2 = GameObject.Find("Up2").GetComponent<Button>();
        Panel3 = GameObject.Find("Up3").GetComponent<Button>();
        Panel4 = GameObject.Find("Up4").GetComponent<Button>();
        Panel5 = GameObject.Find("Up5").GetComponent<Button>();
        Panel6 = GameObject.Find("Up6").GetComponent<Button>();
        Panel7 = GameObject.Find("Up7").GetComponent<Button>();
        Panel8 = GameObject.Find("Up8").GetComponent<Button>();
        Panel9 = GameObject.Find("Up9").GetComponent<Button>();

    }



	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
