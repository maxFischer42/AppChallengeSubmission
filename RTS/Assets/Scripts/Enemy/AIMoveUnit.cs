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
    public float timer;
    public int decideRange;

	// Gather all of the positions of the player's units
	void Awake ()
    {
        AIUnits = GameObject.FindGameObjectsWithTag("Enemy");
        playerUnits = GameObject.FindGameObjectsWithTag("Player");
        currentTarget = GameObject.FindGameObjectsWithTag("Player")[0];

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
        

        

        if (timer >= i)
        {
            if (currentTarget.GetComponent<unitHealth>().HP > 0 || currentTarget == null)
            {
                return;
            }
            else
            {
                currentTarget = FindTarget();
            }
            timer = 0f;
        }

        if (currentTarget.GetComponent<unitHealth>().HP > 0)
        {
            for (int a = 0; a < AIUnits.Length; a++)
            {
                AIUnits[a].GetComponent<NavMeshAgent>().destination = currentTarget.transform.position;
                Debug.Log("New Target = " + currentTarget);

            }
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
