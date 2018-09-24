using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backspaceToMenu : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Backspace))
        {
            SceneManager.LoadScene("Main");
        }
	}
}
