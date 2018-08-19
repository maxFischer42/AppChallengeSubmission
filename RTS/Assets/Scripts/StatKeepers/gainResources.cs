using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gainResources : MonoBehaviour {

    public int Days = 1;
    public int dailyFood = 200;
    public int dailyIron = 150;
    public int dailyCopper = 100;
    public int dailyUranium = 5;
    public int increment;
    public float counter;
    public int part = 0;
    public bool battle;
    public Image rend;
    public Text txt;
    public Sprite[] incrementSprite = new Sprite[21];
    public purchases dataObject;
	
	// Update is called once per frame
	void Update ()
    {
		if (!battle){
            txt.text = "Day " + Days;
            counter += Time.deltaTime;
            if(counter >= 0.7f)
            {
                part++;
                counter = 0;
                rend.sprite = incrementSprite[part];
                if (part >= 20)
                {
                    part = 0;
                    Days++;
                    txt.text = "Day " + Days;
                    dataObject.iron += dailyIron;
                    dataObject.copper += dailyCopper;
                    dataObject.food += dailyFood;
                    dataObject.uranium += dailyUranium;
                }
            }
            

                    

            
        }
	}


}
