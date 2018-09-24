using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class spawnerAI : MonoBehaviour {

    public float interval = 10f;
    public GameObject creation;
    private float timer;
    public int maxpopulation = 10;
    private int pop;



    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;
        if(timer > interval && pop != maxpopulation)
        {
            pop++;
            GameObject a;

            a = (GameObject)Instantiate(creation, transform);
            
            timer = 0;
        }
	}


}
