using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickBuilding : MonoBehaviour
{

    public selectBuilding script;

    private void OnMouseDown()
    {
        script.Call();
    }

}
