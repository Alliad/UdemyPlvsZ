using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreMonitor : MonoBehaviour {

    TextMeshProUGUI scoreText;
    GameStatus gameStatus;

    // Use this for initialization
    void Start () {
        //Debug.Log("Execute start method");
        scoreText = GetComponent<TextMeshProUGUI>();
        gameStatus = FindObjectOfType<GameStatus>();
        //Debug.Log("Game Score " + gameStatus.ReturnScore());

    }
	
	// Update is called once per frame
	void Update () {
        DisplayScore();
        //Debug.Log("Execute Update method");
    }

    private void DisplayScore()
    {
        scoreText.text = gameStatus.ReturnScore().ToString();
    }
}
