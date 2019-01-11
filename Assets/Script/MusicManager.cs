using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicChangeArray;
    [SerializeField] private AudioClip winConditionClip;
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

    public void PlayWinMusic()
    {
        Debug.Log("Play music method start");
        source.clip = winConditionClip;
        source.loop = false;
        source.Play();
    }

    internal void ChangeVolume(float value)
    {
        source.volume = value;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
