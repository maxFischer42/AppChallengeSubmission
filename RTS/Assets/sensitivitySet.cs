using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sensitivitySet : MonoBehaviour {

    public InputField input;


	public void changeValue()
    {
        int i;
        int.TryParse(input.text, out i);
        PlayerPrefs.SetInt("Sensitivity", i);
    }
}
