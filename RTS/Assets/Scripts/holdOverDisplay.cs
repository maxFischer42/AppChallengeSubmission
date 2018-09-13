using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class holdOverDisplay : MonoBehaviour {

    //when the mouse scrolls over the button
    //that is used to purchase a building
    public GameObject display;
    public Text IronAmount;
    public Text CopperAmount;
    public Text FoodAmount;
    public Text UraniumAmount;

    public int Iron;
    public int Copper;
    public int Food;
    public int Uranium;


    public void Do()
    {
       
    
    display.SetActive(true);
        IronAmount.text = "Iron: " + Iron;
        CopperAmount.text = "Copper: " + Copper;
        FoodAmount.text = "Food: " + Food;
        UraniumAmount.text = "Uranium: " + Uranium;
    }

   public void Dont()
    {
        display.SetActive(false);
    }


}
