using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSetter : MonoBehaviour
{
    private Pin[] pinsArray;
    private int standingPinsCount;
    

    // Start is called before the first frame update
    void Start()
    {
        pinsArray = FindObjectsOfType<Pin>();
        standingPinsCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("STanding pins count " + CountStandingPins());
    }

    public int CountStandingPins()
    {
        for (int i = 0; i < pinsArray.Length; i++)
        {
            if (pinsArray[i].IsStanding())
            {
                standingPinsCount++;
            }
        }
        return standingPinsCount;
    }
}
