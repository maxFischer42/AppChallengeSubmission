using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickBuilding : MonoBehaviour
{

    public selectBuilding script;
    public dontSelect dont;

    private void OnMouseDown()
    {
        if (!dont.boolean)
        {
            script.Call();
        }
    }

}
