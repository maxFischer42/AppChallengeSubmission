using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class difficultyCheck : MonoBehaviour {
    public GameObject[] en;

    //checks what the difficulty is compared to the DataHolderObject
    private void Start()
    {
        int i = GameObject.FindObjectOfType<areasKept>().GetComponent<areasKept>().difficulty;
        en[i].SetActive(true);        
    }




}
