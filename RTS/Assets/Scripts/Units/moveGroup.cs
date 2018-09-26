using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class moveGroup : MonoBehaviour
{
    public GameObject[] units;
    public Transform unitLocation;
    public GameObject particle;
    public NavMeshAgent[] nav;
    public float distance = 100f;


    private void Update()
    {
        if (Input.GetAxisRaw("Fire1") == 0)
        {
            return;
        }
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, distance))
        {

            for(int i = 0; i < units.Length; i++)
            {
                units[i].GetComponent<NavMeshAgent>().SetDestination(hit.point);                
            }
            gameObject.GetComponent<Canvas>().enabled = false;

        }
    }




}
