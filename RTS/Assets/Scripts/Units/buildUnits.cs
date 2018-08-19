using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RTS_Cam;

public class buildUnits : MonoBehaviour {

    public GameObject ObjectToMake;
    public GameObject DataHolder;
    public Vector3[] placeToSpawn;
    public float timerInBetween;
    private float timer;

    private void Start()
    {
        DataHolder = GameObject.Find("DataHolderObject");
    }


    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;
        if(timer >= timerInBetween)
        {
            if(DataHolder.GetComponent<purchases>().pop < DataHolder.GetComponent<purchases>().maxpop)
            {
                DataHolder.GetComponent<purchases>().pop++;
                    timer = 0;
                GameObject newUnit = (GameObject)Instantiate(ObjectToMake, placeToSpawn[Random.Range(0, placeToSpawn.Length - 1)], Quaternion.identity);
                newUnit.transform.parent = null;
            }
        }
	}
}
