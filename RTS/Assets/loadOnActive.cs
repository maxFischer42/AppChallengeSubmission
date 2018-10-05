using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadOnActive : MonoBehaviour {

    public string levelToLoad;

    // Use this for initialization
    void Start () {
        PlayerPrefs.SetInt("Sensitivity", 15);
        SceneManager.LoadScene(levelToLoad);
	}

}
