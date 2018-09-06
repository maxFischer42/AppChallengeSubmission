using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMoveUnit : MonoBehaviour {

    public GameObject[] AIUnits;
    public GameObject[] playerUnits;
    public GameObject currentTarget;
    public int difficulty;
    public float timeDiff;
    private float timer;
    public int decideRange;

	// Gather all of the positions of the player's units
	void Awake ()
    {
        AIUnits = GameObject.FindGameObjectsWithTag("AI");
        playerUnits = GameObject.FindGameObjectsWithTag("Player");
	}
	
	// Update is called once per frame
    //Wait specified amounts of time to
    //change target, or change if target
    //is destroyed
	void Update ()
    {
        playerUnits = GameObject.FindGameObjectsWithTag("Player");
        timer += Time.deltaTime;
        float i = timeDiff / difficulty;
        

        if(currentTarget)
        {
            Debug.Log("Target Exists");
            for (int a = 0; a < AIUnits.Length;a++)
            {
                Debug.Log("Target changed");
                AIUnits[a].GetComponent<NavMeshAgent>().destination = currentTarget.transform.position;
               
            }
        }

        if (timer >= i)
        {
            if (currentTarget)
            {
                return;
            }
            else
            {
                currentTarget = FindTarget();
            }
            timer = 0f;
        }
    }

    public GameObject FindTarget()
    {
        if (playerUnits.Length > 0)
        {
            int a = Random.Range(0, decideRange);
            GameObject i = playerUnits[a];
            return i;
        }
        return null;
    }
}
