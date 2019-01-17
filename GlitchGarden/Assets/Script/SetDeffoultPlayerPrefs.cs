using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDeffoultPlayerPrefs : MonoBehaviour {

    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFFICULTY_KEY = "difficulty";

    // Use this for initialization
    void Start () {

        
        if (PlayerPrefs.HasKey(DIFFICULTY_KEY) == false)
        {
            PlayerPrefsManager.SetDifficulty(1f);
        }
        if (PlayerPrefs.HasKey(MASTER_VOLUME_KEY) == false)
        {
            PlayerPrefsManager.SetMasterVolume(0.3f);
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
