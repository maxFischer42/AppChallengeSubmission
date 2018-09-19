using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DetectInRange : MonoBehaviour {

    public string gameEndCutscene;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Cannon")
        {
            SceneManager.LoadScene(gameEndCutscene);
        }
    }




}
