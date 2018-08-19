using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitHealth : MonoBehaviour {

    public int HP = 10;
    public int armor = 0;



    private void Update()
    {
        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }





}
