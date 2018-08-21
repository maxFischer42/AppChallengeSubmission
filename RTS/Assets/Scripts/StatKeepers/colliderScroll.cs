using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderScroll : boxSelectUnits
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            GameObject[] hold = par.unitArray;
            par.unitArray = new GameObject[unitArray.Length + 1];
            for (int x = 0; x < hold.Length; x++)
            {
                par.unitArray[x] = hold[x];
            }
            par.unitArray[unitArray.Length] = other;
        }
    }



}
