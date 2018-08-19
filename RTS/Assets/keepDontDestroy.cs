using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keepDontDestroy : MonoBehaviour {

    public GameObject dont;
	
	// Update is called once per frame
	void Update ()
    {
		if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Territories"))
        {
            dont.SetActive(true);
        }
        else
        {
            dont.SetActive(false);
        }
	}

}
