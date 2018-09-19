using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CannonMovement : MonoBehaviour {

    public Transform cannonDestination;
    private NavMeshAgent nav;

    private void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }


    // Update is called once per frame
    void Update ()
    {
        nav.destination = cannonDestination.position;
	}
}
