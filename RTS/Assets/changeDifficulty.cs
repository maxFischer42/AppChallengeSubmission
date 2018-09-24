using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeDifficulty : MonoBehaviour {

    public int currentDifficulty = 1;

    public void increase()
    {
        switch(currentDifficulty)
        {
            case 1:
                currentDifficulty = 2;
                break;
            case 2:
                currentDifficulty = 3;
                break;
        }
    }

}
