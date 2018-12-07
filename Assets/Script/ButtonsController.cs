using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsController : MonoBehaviour {

    [SerializeField] GameObject[] buttons;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    internal void SwitchButtons(String buttonName)
    {
        foreach (GameObject button in buttons)
        {
            if (button.name != buttonName)
            {
                button.GetComponent<Button>().DrawButtonToColor(Color.black);
            }
        }
    }
}
