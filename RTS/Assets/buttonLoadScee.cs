using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonLoadScee : MonoBehaviour {
    public string levelToLoad;

    public void Pressbutton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(levelToLoad);
    }
}
