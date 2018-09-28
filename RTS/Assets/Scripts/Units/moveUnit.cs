using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class moveUnit : MonoBehaviour {

    public Transform unitLocation;
    //public GameObject particle;
    public NavMeshAgent nav;
    public float distance = 50f;
    public Animator anim;

    private void Update()
    {

        if(nav.destination.x == nav.gameObject.transform.position.x && nav.destination.z == nav.gameObject.transform.position.z)
        {
            anim.SetBool("firing", true);
            anim.SetBool("isWalking", false);
        }


        if (Input.GetAxisRaw("Fire1") == 0)
        {
            return;
        }
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, distance))
        {
           // GameObject aa = (GameObject)Instantiate(particle, hit.point, Quaternion.identity);
           // Destroy(aa, 4.5f);
            anim.SetBool("isWalking", true);
            nav.SetDestination(hit.point);
            gameObject.SetActive(false);
            
        }
    }




}
