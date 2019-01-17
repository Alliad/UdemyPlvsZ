using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] attackerPrefab;
       

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject currentAttacker in attackerPrefab)
        {
            if (isTimeToSpawn(currentAttacker))
            {
                Spawen(currentAttacker);
            }
        }
    }

    private void Spawen(GameObject currentAttacker)
    {
        GameObject myAttacker = Instantiate(currentAttacker) as GameObject;
        myAttacker.transform.parent = transform;
        myAttacker.transform.position = transform.position;
    }

    private bool isTimeToSpawn(GameObject currentAttacker)
    {
        //currentAttacker.GetComponent<Attacker>().seenEverySeconds Time.timeSinceLevelLoad
        Attacker attacker = currentAttacker.GetComponent<Attacker>();

        float meanSpawnDelayInSeconds = attacker.seenEverySeconds;
        float spawnPerSecond = 1 / meanSpawnDelayInSeconds;

        if (Time.deltaTime > meanSpawnDelayInSeconds)
        {
            Debug.LogWarning("Spawn rate capped by frame rate");
        }

        float threshold = spawnPerSecond * Time.deltaTime / 5;
        //Debug.Log("SpawnPerSecond = " + spawnPerSecond);
        //Debug.Log("Time.deltaTime = " + Time.deltaTime);
        //Debug.Log("Threshold = " + threshold);

        return (UnityEngine.Random.value < threshold);        
    }
}
