﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class purchases : boolsToKeep {

    /*
     * 
     * This script is used to keep track of purchases made
     * throughout the game. These will also be the values
     * that will be saved to a file when the game is
     * commanded to save progress.
     * 
     */

    public Text ironDis;
    public Text foodDis;
    public Text coppDis;
    public Text uranDis;
    public Text popDis;

    public gainResources gr;


    [Header("Buttons to Assign")]
    public Button RCLivingQuartersButton;
    public Button MPLivingQuartersButton;
    public Button RPLivingQuartersButton;
    public Button MFLivingQuartersButton;

    public Button RCIronButton;
    public Button RDIronButton;

    public Button RCCopperButton;
    public Button RDCopperButton;

    public Button RCFoodButton;
    public Button RDFoodButton;

    public Button RCUranButton;
    public Button RDUranButton;

    public Button RCTrainingFacilityButton;
    public Button RPTrainingFacilityButton;
    public Button MFTrainingFacilityButton;

    public Button MPAIResearchButton;
    public Button RPAIResearchButton;

    public Button MPElectricButton;

    public Button MPHeavyButton;

    public Button MPAirButton;
    public Button MFAirButton;

    public Button MPGroundButton;
    public Button MFGroundButton;

    public Button RPFlyMechButton;
    public Button MFFlyMechButton;

    public Button RPLargeMechButton;

    public Button RPcommsButton;


    // Use this for initialization
    void Start() {
        if(GameObject.FindGameObjectWithTag("Data").gameObject != gameObject)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
        
    }

    // Update is called once per frame
    void Update() {

    }



    

    //purchasing living quarters

    public void buyRCLivingQuarters()
    {
        bool i = PurchaseLivingQuarters();
        if (!i)
        {
            return;
        }
        RCLivingQuartersButton.interactable = false;
        RCLivingQuarters = true;
    }
    public void buyMPLivingQuarters()
    {
        bool i = PurchaseLivingQuarters();
        if(!i)
        {
            return;
        }
        MPLivingQuartersButton.interactable = false;
        MPLivingQuarters = true;
    }
    public void buyRPLivingQuarters()
    {
        bool i = PurchaseLivingQuarters();
        if (!i)
        {
            return;
        }
        PurchaseLivingQuarters();
        RPLivingQuartersButton.interactable = false;
        RPLivingQuarters = true;
    }
    public void buyMFLivingQuarters()
    {
        bool i = PurchaseLivingQuarters();
        if (!i)
        {
            return;
        }
        PurchaseLivingQuarters();
        MFLivingQuartersButton.interactable = false;
        MFLivingQuarters = true;
    }
    public bool PurchaseLivingQuarters()
    {
        if (iron >= 10)
        {
            iron -= 10;
            maxpop += 10;
            return true;
        }
        return false;
    }

    //purchasing AI research lab

    public void MPai()
    {
        if (iron >= 75 && copper >= 50)
        {
            buyAI();
            MPAIResearchButton.interactable = false;
            MPAIResearchLab = true;
        }
    }
    public void RPai()
    {
        if (iron >= 75 && copper >= 50)
        {
            buyAI();
            RPAIResearchButton.interactable = false;
            RPAIResearchLab = true;
        }
    }
    public void buyAI()
    {
        iron -= 75;
        copper -= 50;
    }

    //purchasing Electric research lab

    public void MPElectric()
    {
        if (iron >= 150 && copper >= 175)
        {
            buyElec();
            MPAIResearchButton.interactable = false;
            MPAIResearchLab = true;
        }
    }
    public void buyElec()
    {
        iron -= 150;
        copper -= 175;
    }

    //purchasing Heavy Production

    public void MPHeavy()
    {
        if (iron >= 450 && copper >= 350)
        {
            buyHeavy();
            MPHeavyButton.interactable = false;
            MPHeavyResearchLab = true;
        }
    }
    public void buyHeavy()
    {
        iron -= 450;
        copper -= 350;
    }

    //purchasing Air Factory

    public void MPAir()
    {
        if (iron >= 750 && copper >= 550)
        {
            buyAir();
            MPAirButton.interactable = false;
            MPAirFactory = true;
        }
    }
    public void MFAir()
    {
        if (iron >= 750 && copper >= 550)
        {
            buyAir();
            MFAirButton.interactable = false;
            MFAirFactory = true;
        }
    }
    public void buyAir()
    {
        iron -= 750;
        copper -= 550;
    }

    //purchasing Ground Factory

    public void MPGround()
    {
        if (iron >= 450 && copper >= 500)
        {
            buyGround();
            MPGroundButton.interactable = false;
            MPGroundMechFactory = true;
        }
    }
    public void MFGround()
    {
        if (iron >= 450 && copper >= 500)
        {
            buyGround();
            MFGroundButton.interactable = false;
            MFGroundMechFactory = true;
        }
    }
    public void buyGround()
    {
        iron -= 450;
        copper -= 500;
    }

    //purchasing Flying Mech

    public void MFFly()
    {
        if (iron >= 300 && copper >= 250)
        {
            buyFly();
            MFFlyMechButton.interactable = false;
            MFFlyingMechFactory = true;
        }
    }
    public void RPFly()
    {
        if (iron >= 300 && copper >= 250)
        {
            buyFly();
            RPFlyMechButton.interactable = false;
            RPFlyingMechFactory = true;
        }
    }
    public void buyFly()
    {
        iron -= 300;
        copper -= 250;
    }


    //purchasing Large Mech

    public void RPlarge()
    {
        if (iron >= 500 && copper >= 150)
        {
            buyLarge();
            RPLargeMechButton.interactable = false;
            RPLargeMechFactory = true;
        }
    }
    public void buyLarge()
    {
        iron -= 500;
        copper -= 150;
    }

    //purchasing Comms Depot

    public void RPcomms()
    {
        if (iron >= 200 && copper >= 200)
        {
            buyComms();
            RPcommsButton.interactable = false;
            RPCommsDepot = true;
        }
    }
    public void buyComms()
    {
        iron -= 200;
        copper -= 200;
    }

    //purchasing iron

    public void buyRCIron()
    {
       bool i = PurchaseIron();
        if (!i)
        {
            return;
        }
        RCIronButton.interactable = false;
        RCIronSmelthouse = true;
    }
    public void buyRDIron()
    {

       bool i = PurchaseIron();
        if (!i)
        {
            return;
        }
        RDIronButton.interactable = false;
        RDIronSmelthouse = true;
    }
    public bool PurchaseIron()
    {
        if (iron >= 15)
        {
            iron -= 15;
            gr.dailyIron += 300;
            return true;
        }
        return false;
    }


    //purchasing copper

    public void buyRCCop()
    {
        bool i =PurchaseCop();
        if (!i)
        {
            return;
        }
        RCCopperButton.interactable = false;
        RCCopperSmelthouse = true;
    }
    public void buyRDCop()
    {
        bool i =PurchaseCop();
        if (!i)
        {
            return;
        }
        RDCopperButton.interactable = false;
        RDCopperSmelthouse = true;
    }
    public bool PurchaseCop()
    {
        if (copper >= 15 && iron >= 25)
        {
            iron -= 25;
            copper -= 15;
            gr.dailyCopper += 250;
            return true;
        }
        return false;
    }


    //purchasing food

    public void buyRCFood()
    {
       bool i = PurchaseFood();
        if (!i)
        {
            return;
        }
        RCFoodButton.interactable = false;
        RCFoodProcCentre = true;
    }
    public void buyRDFood()
    {
        bool i = PurchaseFood();
        if (!i)
        {
            return;
        }
        RDFoodButton.interactable = false;
        RDFoodProcCentre = true;
    }
    public bool PurchaseFood()
    {
        if (iron >= 50)
        {
            iron -= 50;
            gr.dailyFood += 200;
            return true;
        }
        return false;
    }


    //purchasing uranium

    public void buyRCUran()
    {
        bool i = PurchaseUran();
        if (!i)
        {
            return;
        }
        RCUranButton.interactable = false;
        RCUraniumExtractors = true;
    }
    public void buyRDUran()
    {
        bool i = PurchaseUran();
        if (!i)
        {
            return;
        }
        RDUranButton.interactable = false;
        RDUraniumExtractors = true;
    }
    public bool PurchaseUran()
    {
        if (iron >= 5000)
        {
            iron -= 5000;
            gr.dailyUranium += 250;
            return true;
        }
        return false;
    }


    //training facility

    public void RCTraining()
    {
        if(iron >= 50 && copper >= 25)
        {
            buyTraining();
            RCTrainingFacilityButton.interactable = false;
            RCTrainingFacility = true;
        }
    }
    public void RPTraining()
    {
        if (iron >= 50 && copper >= 25)
        {
            buyTraining();
            RPTrainingFacilityButton.interactable = false;
            RPTrainingFacility = true;
        }
    }
    public void MFTraining()
    {
        if (iron >= 50 && copper >= 25)
        {
            buyTraining();
            MFTrainingFacilityButton.interactable = false;
            MFTrainingFacility = true;
        }
    }
    public void buyTraining()
    {
        iron -= 50;
        copper -= 25;
    }




    private void FixedUpdate()
    {
        foodDis.text = "Food: " + food;
        ironDis.text = "Iron: " + iron;
        coppDis.text = "Copper: " + copper;
        uranDis.text = "Uranium: " + uranium;
        popDis.text = "Population: " + pop;

    }








}

public class boolsToKeep : MonoBehaviour
{
    [Header("Values to Save")]
    public int iron;
    public int copper;
    public int food;
    public int uranium;
    public float ironInc;
    public float copperInc;
    public float foodInc;
    public float uraniumInc;
    public int pop;
    public int maxpop = 20;


    [Header("Reactor Core Purchases")]
    public bool RCLivingQuarters;
    public bool RCIronSmelthouse;
    public bool RCCopperSmelthouse;
    public bool RCFoodProcCentre;
    public bool RCTrainingFacility;
    public bool RCUraniumExtractors;

    [Header("Mech Production Facility Purchases")]
    public bool MPLivingQuarters;
    public bool MPAIResearchLab;
    public bool MPElectronicResearchLab;
    public bool MPHeavyResearchLab;
    public bool MPAirFactory;
    public bool MPGroundMechFactory;

    [Header("River Patrol Station Purchases")]
    public bool RPLivingQuarters;
    public bool RPTrainingFacility;
    public bool RPFlyingMechFactory;
    public bool RPLargeMechFactory;
    public bool RPCommsDepot;
    public bool RPAIResearchLab;

    [Header("Military Facility Purchases")]
    public bool MFLivingQuarters;
    public bool MFTrainingFacility;
    public bool MFAirFactory;
    public bool MFFlyingMechFactory;
    public bool MFGroundMechFactory;

    [Header("Resource Development Purchases")]
    public bool RDIronSmelthouse;
    public bool RDCopperSmelthouse;
    public bool RDFoodProcCentre;
    public bool RDUraniumExtractors;


}