using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkMe : MonoBehaviour {

   public  bool truefalse;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
            truefalse = false;
    }

}
