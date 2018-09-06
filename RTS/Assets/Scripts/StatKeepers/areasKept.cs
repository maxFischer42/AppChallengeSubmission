using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class areasKept : MonoBehaviour {

    public int difficulty = 0;
 
    public bool RD;
    public bool MF;
    public bool RP;
    public bool MP;
    public bool RC;

    public Text RDStatus;
    public Text MFStatus;
    public Text RPStatus;
    public Text MPStatus;
    public Text RCStatus;

    public GameObject RDd;
    public GameObject MFd;
    public GameObject RPd;
    public GameObject MPd;
    public GameObject RCd;


    // Update is called once per frame
    void Update ()
    {
		if(RD)
        {
            RDStatus.text = "Status: Lost";
            Destroy(RDd);
        }
        else
        {
            RDStatus.text = "Status: Defended";
        }

        if (MF)
        {
            MFStatus.text = "Status: Lost";
            Destroy(MFd);
        }
        else
        {
            MFStatus.text = "Status: Defended";
        }

        if (RP)
        {
            RPStatus.text = "Status: Lost";
            Destroy(RPd);
        }
        else
        {
            RPStatus.text = "Status: Defended";
        }

        if (MP)
        {
            MPStatus.text = "Status: Lost";
            Destroy(MPd);
        }
        else
        {
            MPStatus.text = "Status: Defended";
        }

        if (RC)
        {
            RCStatus.text = "Status: Lost";
            Destroy(RCd);
        }
        else
        {
            RCStatus.text = "Status: Defended";
        }


    }
}
