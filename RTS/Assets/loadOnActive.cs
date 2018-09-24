using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadOnActive : MonoBehaviour {

    public string levelToLoad;

    // Use this for initialization
    void Start () {
        SceneManager.LoadScene(levelToLoad);
	}

}
