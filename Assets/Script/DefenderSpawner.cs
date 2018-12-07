using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        Debug.Log(Input.mousePosition);
        Debug.Log(CalculateWorldPointsOfMouseClick());
    }

    Vector2 CalculateWorldPointsOfMouseClick()
    {
        return new Vector2(0, 0);
    }
}
