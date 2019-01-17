using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splashBehavier : MonoBehaviour {

    [SerializeField] float daleyInSeconds = 3f;

    // Use this for initialization
    void Start () {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "SplashScreen")
        {
            StartCoroutine(LoadStartScene()); 
        }

        //Debug.Log("Active scene is '" + scene.name + "'.");
    }

    private IEnumerator LoadStartScene()
    {
        yield return new WaitForSeconds(daleyInSeconds);
        SceneManager.LoadScene(1);
    }

}
