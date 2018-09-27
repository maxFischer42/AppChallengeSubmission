using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class musicPlayer : MonoBehaviour {

    public AudioSource p_music;
	
	// Update is called once per frame
	void Update ()
    {
        p_music.volume = PlayerPrefs.GetFloat("Music");
    }
}
