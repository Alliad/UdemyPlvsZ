using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour {

    [SerializeField] int scorePerKill;
    [SerializeField] int score = 0;

    private void Awake()
    {
        if (FindObjectsOfType<GameStatus>().Length > 1)
        {
            Destroy(gameObject);
            //Debug.Log("GameStatus was destroyed ");
            //Debug.Log("Current score " + score);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            //Debug.Log("GameStatus DONT destroyed ");
            //Debug.Log("Current score " + score);
        }
    }

    public void AddToScore()
    {
        score += scorePerKill;
    }

    public void ResetGameScore()
    {
        Destroy(gameObject);
    }

    public int ReturnScore()
    {
        return score;
    }

}
