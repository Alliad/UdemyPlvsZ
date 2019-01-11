using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [SerializeField] private float winConditionTime;
    [SerializeField] private SceneLoader mySceneLoader;
    private Slider timeToTheEndOfTheLevelSlider;
    private MusicManager myMusicManager;
    

    // Start is called before the first frame update
    void Start()
    {
        myMusicManager = FindObjectOfType<MusicManager>();
        timeToTheEndOfTheLevelSlider = GetComponent<Slider>();
        timeToTheEndOfTheLevelSlider.maxValue = winConditionTime;
        MoveSlider();
        //attackerSpawner = GameObject.Find("Spawners");
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    void MoveSlider()
    {
        while (Time.timeSinceLevelLoad < winConditionTime)
        {
            timeToTheEndOfTheLevelSlider.value = Time.timeSinceLevelLoad;
        }

    }

}
