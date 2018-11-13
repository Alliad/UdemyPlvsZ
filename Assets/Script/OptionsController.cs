using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

    public Slider volumeSlider, difficultySlider;
    public SceneLoader levelManager;
    

    private MusicManager musicManager;

    // Use this for initialization
	void Start () {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        Debug.Log(musicManager);

        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        difficultySlider.value = PlayerPrefsManager.GetDifficulty();
        Debug.Log("Difficulty value is " + PlayerPrefsManager.GetDifficulty());
	}
	
	// Update is called once per frame
	void Update () {
        musicManager.ChangeVolume(volumeSlider.value);
	}

    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
        Debug.Log(volumeSlider.value);

        PlayerPrefsManager.SetDifficulty(difficultySlider.value);
        Debug.Log(difficultySlider.value);

        levelManager.LoadStartMenu();
    }

    public void SetDeffaults()
    {
        volumeSlider.value = 0.2f;
        difficultySlider.value = 2f;
    }
}
