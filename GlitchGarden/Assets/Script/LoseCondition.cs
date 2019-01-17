using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCondition : MonoBehaviour
{
    [SerializeField] private SceneLoader sceneLoader;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sceneLoader.LoadLoseScene();
    }
}
