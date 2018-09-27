using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundChange : MonoBehaviour {

    public Slider slider_obj;
    public bool isMusic;

    public void changeValue()
    {
        if(isMusic)
        {
            PlayerPrefs.SetFloat("Music", slider_obj.value);
        }
        else
        {
            PlayerPrefs.SetFloat("Sound", slider_obj.value);
        }
    }
	
}
