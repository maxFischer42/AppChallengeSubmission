using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class moveGroup : MonoBehaviour
{
    public GameObject[] units;
    public Transform unitLocation;
    public GameObject particle;
    public NavMeshAgent[] nav;
    public float distance = 100f;
    public bool isSelecting = false;
    


    private void Update()
    {
        if (Input.GetAxisRaw("Fire1") == 0 || !isSelecting)
        {
            return;
        }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, distance))
        {
          /*  if (EventSystem.current.IsPointerOverGameObject())
            {
                return;
            }
          */

            for (int i = 0; i < units.Length; i++)
            {
                units[i].GetComponent<NavMeshAgent>().SetDestination(hit.point);                
            }
            gameObject.GetComponent<Canvas>().enabled = false;
            isSelecting = false;
            enabled = false;

        }
    }




}
