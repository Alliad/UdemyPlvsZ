using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinSetter : MonoBehaviour
{
    [SerializeField] private Text standingPinsDisplay;
    private Pin[] pinsArray;
      

    // Start is called before the first frame update
    void Start()
    {
        pinsArray = FindObjectsOfType<Pin>();
        
    }

    // Update is called once per frame
    void Update()
    {
        standingPinsDisplay.text = CountStandingPins().ToString();
    }

    public int CountStandingPins()
    {
        int standingPinsCount = 0;
        for (int i = 0; i < pinsArray.Length; i++)
        {
            if (pinsArray[i].IsStanding())
            {
                standingPinsCount++;
            }
        }
        return standingPinsCount;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Ball>())
        {
            standingPinsDisplay.color = Color.red;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.transform.parent.gameObject);
        Destroy(other.transform.parent.gameObject);

        if (other.GetComponent<Pin>())
        {
            
        }
        
    }
}
