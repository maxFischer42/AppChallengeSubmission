﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class unitCanvas : MonoBehaviour {
    /*
     * this script is used to store all the main
     * data for a single unit.
     * this script also references other scripts
     * with functions relating to this one.
    */

        [Header("IDs")]
    public selectUnit sel;
    public GameObject moveUnitCanvas;

    public int Enter_The_Unit_ID_Here;
    public NameStatKeeper statKeeperObj;




    public string unitName;

    public float unitHP;

    public float unitDamage;

    public float unitDefense;

    public string unitAbility;








    // Use this for initialization
    void Awake ()
    {
        BasedOffID();

	}
	


    public void ClickMove()
    {
        moveUnitCanvas.SetActive(true);
        sel.OnMouseDown();
    }

    /*
     * This function
     * sets the stats of specific units
     * based off an ID specified when they
     * are created.
     * Each ID represents a different unit
     * variation.
     */
    void BasedOffID()
    {
        unitName = statKeeperObj.nameIDS[Enter_The_Unit_ID_Here];
        unitHP = statKeeperObj.healthIDS[Enter_The_Unit_ID_Here];
        unitDamage = statKeeperObj.damageIDS[Enter_The_Unit_ID_Here];
        unitDefense = statKeeperObj.defIDS[Enter_The_Unit_ID_Here];
        unitAbility = statKeeperObj.abilityIDS[Enter_The_Unit_ID_Here];
    }








}

    
