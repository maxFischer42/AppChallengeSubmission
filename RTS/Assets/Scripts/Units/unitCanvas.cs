using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

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

    public unitHealth HPScript;

    [Header("Gameobjects")]
    public Text Name;
    public Text dmg;
    public Text arm;
    public Text abil;
    public Scrollbar hp;






    // Use this for initialization
    void Awake ()
    {
        BasedOffID();

	}


    private void FixedUpdate()
    {
        Name.text = unitName;
        dmg.text = "Damage Amount: " + unitDamage.ToString();
        arm.text = "Armor Amount: " + unitDefense.ToString();
        abil.text = "Ability: " + unitAbility;
        hp.size = HPScript.HP / unitHP;
    }


    public void ClickMove()
    {
        moveUnitCanvas.SetActive(true);
        gameObject.GetComponent<Canvas>().enabled = false;
        sel.OnMouseDown();
    }

    public void ClickDeselect()
    {
        gameObject.GetComponent<Canvas>().enabled = false;
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

    

