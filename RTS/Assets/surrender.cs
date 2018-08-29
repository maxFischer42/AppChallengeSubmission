using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class surrender : MonoBehaviour {

    public areasKept area;
    public purchases data;
    public attackers obj;

    private void Start()
    {
        area = GameObject.Find("DataHolderObject").GetComponent<areasKept>();
        data = GameObject.Find("DataHolderObject").GetComponent<purchases>();
        obj = GameObject.Find("BattleInitiateCanvas").GetComponent<attackers>();
    }


    public void button()
    {
        data.pop = 0;
        if (!area.RD)
        {
            area.RD = true;
            obj.area1 = true;
            SceneManager.LoadScene("Territories");
        }
        else if (!area.MF)
        {
            area.MF = true;
            obj.area2 = true;
            SceneManager.LoadScene("Territories");
        }
        else if (!area.RP)
        {
            area.RP = true;
            obj.area3 = true;
            SceneManager.LoadScene("Territories");
        }
        else if (!area.MP)
        {
            area.MP = true;
            obj.area4 = true;
            SceneManager.LoadScene("Territories");
        }
        else if (!area.RC)
        {
            area.RC = true;
            obj.area5 = true;
            SceneManager.LoadScene("Territories");
        }
        

    }


}
