using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour {

    [SerializeField] public int starCoast;
    StarDisplay starDisplay;

    private void Start()
    {
        starDisplay = GameObject.FindObjectOfType<StarDisplay>();
    }

    public void AddStars(int count)
    {
        starDisplay.AddStars(count);
    }
}
