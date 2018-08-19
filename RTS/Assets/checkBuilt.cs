using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkBuilt : MonoBehaviour {

    public purchases data;
    public string name;

	// Use this for initialization
	void Start () {
        data = GameObject.Find("DataHolderObject").GetComponent<purchases>();
	    switch(name)
        {
            case "RDIron":
                if (!data.RDIronSmelthouse)
                    A();
                break;
            case "RDCopp":
                if (!data.RDCopperSmelthouse)
                    A();
                break;
            case "RDUran":
                if (!data.RDUraniumExtractors)
                    A();
                break;
            case "RDFood":
                if (!data.RDFoodProcCentre)
                    A();
                break;
        }
	}

    void A()
    {
        gameObject.SetActive(false);
    }


}
