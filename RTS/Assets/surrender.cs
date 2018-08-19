using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class surrender : MonoBehaviour {

    public areasKept area;
    public purchases data;

    private void Start()
    {
        area = GameObject.Find("DataHolderObject").GetComponent<areasKept>();
        data = GameObject.Find("DataHolderObject").GetComponent<purchases>();
    }


    public void button()
    {
        data.pop = 0;
        if (!area.RD)
        {
            area.RD = true;
            SceneManager.LoadScene("Territories");
        }
        else if (!area.MF)
        {
            area.MF = true;
            SceneManager.LoadScene("Territories");
        }
        else if (!area.RP)
        {
            area.RP = true;
            SceneManager.LoadScene("Territories");
        }
        else if (!area.MP)
        {
            area.MP = true;
            SceneManager.LoadScene("Territories");
        }
        else if (!area.RC)
        {
            area.RC = true;
            SceneManager.LoadScene("Territories");
        }
        

    }


}
