using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicChangeArray;
    private AudioSource source;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
        source.volume = PlayerPrefsManager.GetMasterVolume();
    }

    private void OnLevelWasLoaded(int level)
    {
        if (levelMusicChangeArray[level])
        {
            
            source.clip = levelMusicChangeArray[level];
            source.loop = true;
            source.Play();
        }
        
    }

    internal void ChangeVolume(float value)
    {
        source.volume = value;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
