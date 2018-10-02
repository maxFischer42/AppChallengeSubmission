using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pauseMenu : MonoBehaviour {

    bool isPaused = false;
    public GameObject canvasPause;


	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                unPause();
            }
            else
            {
                pauseGame();
            }
        }
	}

    public void pauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
        canvasPause.SetActive(true);
    }

    public void unPause()
    {
        isPaused = false;
        Time.timeScale = 1f;
        canvasPause.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
    }

    public void Resume()
    {
        if (isPaused)
        {
            unPause();
        }
        else
        {
            pauseGame();
        }
    }
    
}
