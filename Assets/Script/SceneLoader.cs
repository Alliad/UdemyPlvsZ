using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] float delayInSeconds = 1f;
    [SerializeField] float delayBeforeLoadStartScene = 3f;
    [SerializeField] float delayBeforeLoadWinScene = 3f;

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            Invoke("LoadNextScene", delayBeforeLoadStartScene);
        }
        
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);        
        
    }

    public void LoadStartMenu()
    {
        SceneManager.LoadScene(1);
        
        //FindObjectOfType<GameStatus>().ResetGameScore();
    }

    public void LoadGame()
    {
        //Debug.Log("Load first level");
        SceneManager.LoadScene("02_Level_01");
        //FindObjectOfType<GameStatus>().ResetGameScore();
        //FindObjectOfType<GameStatus>().ResetGameScore();
    }

    /*public void LoadLoseScene()
    {

        StartCoroutine(LoadGameOverSceneCoroutine());
        
    }

    private IEnumerator LoadGameOverSceneCoroutine()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene("03b_LoseScreen");
    }*/

    public void LoadLoseScene()
    {
        SceneManager.LoadScene("03b_LoseScreen");
    }

    public void LoadWinScreen(float delayInSeconds)
    {
        {
            StartCoroutine(LoadWinScreenCoroutine(delayInSeconds));
        }
    }

    private IEnumerator LoadWinScreenCoroutine(float delayInSeconds)
        {
            yield return new WaitForSeconds(delayInSeconds);
            SceneManager.LoadScene("03a_WinScreen");
        }
        
    

    public void LoadOptionsScene()
    {
        SceneManager.LoadScene("01b_Options");
    }

    public void LoadScene(String sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}