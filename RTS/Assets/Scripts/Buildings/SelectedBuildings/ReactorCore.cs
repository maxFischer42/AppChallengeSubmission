using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReactorCore : selectedBuildings {


    public int unitsActive;
    public Vector3 unitWaypoint;
    public int droneCost;

    [Header("Upgrades")]
    public bool droneProductivity1;
    public bool droneProductivity2;
    public bool droneProductivity3;
    public bool advancedElectronics;
    public bool advancedDrills;
    public bool advancedWeaponry;
    public bool advancedDefenses;


    

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isSelected)
        {









        }
	}

    public void select()
    {
        Panel1.GetComponentInChildren<Text>().text = "Drone";
        Panel2.gameObject.SetActive(false);
        Panel3.gameObject.SetActive(false);
        Panel4.gameObject.SetActive(false);
        Panel5.gameObject.SetActive(false);
        Panel6.gameObject.SetActive(false);
        Panel7.GetComponentInChildren<Text>().text = "Drone Productivity 1";
        Panel8.GetComponentInChildren<Text>().text = "Drone Productivity 2";
        Panel9.GetComponentInChildren<Text>().text = "Drone Productivity 3";
    }
}
