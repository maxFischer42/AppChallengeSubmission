using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getVolume : MonoBehaviour {

    public AudioSource aud;
    public float volume;

    public void Start()
    {
        volume = PlayerPrefs.GetFloat("SFXVolume");
        aud = GetComponent<AudioSource>();
        aud.volume = volume;
    }




}
