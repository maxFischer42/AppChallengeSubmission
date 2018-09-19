using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class escortDestination : MonoBehaviour {

    public Transform cannonDestination;
    private NavMeshAgent nav;

    private void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }


}
