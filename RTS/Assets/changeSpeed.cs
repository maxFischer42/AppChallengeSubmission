using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeSpeed : MonoBehaviour {

    float defaultTime = 1f;
    float myTime = 1f;
    public Sprite def;
    public Sprite fast;

    public void Update()
    {
        if(Time.timeScale == defaultTime)
        {
            GetComponent<Button>().image.sprite = def;
        }
    }

    public void OnButtonPress()
    {
        if(Time.timeScale == 1f)
        {
            Time.timeScale = 2f;
            GetComponent<Button>().image.sprite = fast;
        }   
        else
        {
            Time.timeScale = 1f;
            GetComponent<Button>().image.sprite = def;
        }    
    }


}
