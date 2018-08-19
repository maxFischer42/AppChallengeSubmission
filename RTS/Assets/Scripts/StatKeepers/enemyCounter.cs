using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyCounter : MonoBehaviour {

    public int enemies;
    public purchases data;

    private void Start()
    {
        data = GameObject.Find("DataHolderObject").GetComponent<purchases>();
    }


    // Update is called once per frame
    void Update ()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (enemies <= 0)
        {
            data.pop = 0;
            SceneManager.LoadScene("Territories");
            
        }
    }
}
