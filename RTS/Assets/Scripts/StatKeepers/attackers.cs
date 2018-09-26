using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class attackers : MonoBehaviour {

    public bool area1;
    public bool area2;
    public bool area3;
    public bool area4;
    public bool area5;

    public Vector2 chanceTime;
    public float timerObject;
    public float currentTarget;

    public GameObject dis;

    public Canvas battleCanvas;
    public string levelTarget;

    public GameObject dontDestroy;


    private void Start()
    {
        DontDestroyOnLoad(dontDestroy);
    }



    // Update is called once per frame
    void Update ()
    {
        if (SceneManager.GetActiveScene().name != "Territories")
            return;
		if (currentTarget == 0){
            currentTarget = Random.Range(chanceTime.x, chanceTime.y);
        }
        else
        {
            timerObject += Time.deltaTime;
            if(timerObject > currentTarget)

            {
                InitiateBattle();
            }
        }
	}

    void InitiateBattle()
    {
        dis.SetActive(false);
        timerObject = 0;
        Time.timeScale = 0;
        currentTarget = 0;
        battleCanvas.enabled = true;
        LevelSelect();
    }

    void LevelSelect()
    {
        if(!area1)
        {
            levelTarget = "LevelRD";
        }
        else if (!area2)
        {
            levelTarget = "LevelMF";
        }
        else if (!area3)
        {
            levelTarget = "LevelRP";
        }
        else if(!area4)
        {
            levelTarget = "LevelMP";
        }
        else
        {
            levelTarget = "LevelRC";
        }
    }

    public void startLevel()
    {
        dis.SetActive(false);
        /* Camera[] list = GameObject.FindObjectsOfType<Camera>();
         for (int i = 0; i < list.Length; i++)
         {
             list[i].enabled = false;
         }
         GameObject.Find("MainCamera").GetComponent<Camera>().enabled = true;*/
        battleCanvas.enabled = false;
        SceneManager.LoadScene(levelTarget);
        dis.SetActive(true);
        dontDestroy.SetActive(false);
        Time.timeScale = 1;
    }
}
