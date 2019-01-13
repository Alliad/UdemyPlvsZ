using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameTimer : MonoBehaviour
{
    [SerializeField] private float winConditionTime;
    [SerializeField] private SceneLoader mySceneLoader;
    [SerializeField] private WinGrattersText winGrattersText;
    private Slider timeToTheEndOfTheLevelSlider;
    private MusicManager myMusicManager;
    private AudioSource myAudioSource;
    private bool winStatus = false;
    

    // Start is called before the first frame update
    void Start()
    {
        myMusicManager = FindObjectOfType<MusicManager>();
        //myAudioSource = myMusicManager.GetComponent<AudioSource>();
        timeToTheEndOfTheLevelSlider = GetComponent<Slider>();
        timeToTheEndOfTheLevelSlider.maxValue = winConditionTime;

        //MoveSlider();
        //attackerSpawner = GameObject.Find("Spawners");
    }

    // Update is called once per frame
    void Update()
    {
        if (!winStatus)
        {
            timeToTheEndOfTheLevelSlider.value = Time.timeSinceLevelLoad;
            if (Time.timeSinceLevelLoad >= winConditionTime)
            {
                winStatus = true;
                myMusicManager.PlayWinMusic();
                winGrattersText.ShowWinText();
                mySceneLoader.LoadWinScreen(myAudioSource.clip.length);
            }
        }
        /*if (winStatus == true && !myAudioSource.isPlaying == true)
        {
            Debug.Log("Start Win screen load coroutine");
            mySceneLoader.LoadWinScreen(5);
        }*/
    }
}
