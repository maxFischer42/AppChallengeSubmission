using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadingIcon : MonoBehaviour
{

    public GameObject objectToSpawn;


    public void startLoad()
    {
        GameObject loadObj = (GameObject)Instantiate(objectToSpawn, transform);
        DontDestroyOnLoad(loadObj);
        loadObj.GetComponent<checkSceneLoaded>().originalScene = SceneManager.GetActiveScene();
    }




}
