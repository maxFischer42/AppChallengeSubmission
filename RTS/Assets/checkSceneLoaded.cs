using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class checkSceneLoaded : MonoBehaviour {
    public Scene originalScene;

	
	// Update is called once per frame
	void Update ()
    {
		if(originalScene != SceneManager.GetActiveScene())
        {
            Destroy(gameObject);
        }
	}

}
