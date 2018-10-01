using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groupSelect : MonoBehaviour {

    public moveGroup group;

    public void OnSelected(GameObject unit)
    {
        GameObject[] a = new GameObject[group.units.Length + 1];
        for (int i = 0; i < group.units.Length; i++)
        {
            a[i] = group.units[i];
        }
        a[a.Length - 1] = unit;
        group.units = a;        
    }

    public void OnUnSelected()
    {

    }

}
