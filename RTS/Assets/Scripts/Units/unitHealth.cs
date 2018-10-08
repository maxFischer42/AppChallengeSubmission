using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class unitHealth : MonoBehaviour {

    public int HP = 10;
    public int armor = 0;
    public GameObject particle;
    public Transform spawntransform;



    private void Update()
    {
        if (HP <= 0)
        {
            GameObject part = (GameObject)Instantiate(particle,spawntransform);
            Destroy(part, 7f);
            part.transform.parent = null;
            GameObject.FindObjectOfType<moveGroup>().GetComponent<Canvas>().enabled = false;
            GameObject.FindObjectOfType<moveGroup>().isSelecting = false;
            GameObject.FindObjectOfType<moveGroup>().enabled = false;
            Destroy(gameObject);
        }
    }





}
