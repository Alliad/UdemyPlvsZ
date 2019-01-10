using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {

    private GameObject defenderParent;
    private Camera camera;
    private StarDisplay starDisplay;
    
    // Use this for initialization
	void Start () {
        starDisplay = FindObjectOfType<StarDisplay>();
        camera = Camera.main;

        defenderParent = GameObject.Find("DefenderParent");

        if (!defenderParent)
        {
            defenderParent = new GameObject("DefenderParent");
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        //Debug.Log(SnapToGrid(CalculateWorldPointsOfMouseClick(Input.mousePosition)));
        //Debug.Log(Button.selectedDefender.GetComponent<Defender>().starCoast);
        int defenderCost = Button.selectedDefender.GetComponent<Defender>().starCoast;
        if (starDisplay.UseStars(defenderCost) == StarDisplay.Status.SUCCESS)
        {
            SpawnDefender();
        }
        else
        {
            Debug.Log("Insufficient stars, mother fucker)");
        }
        
    }

    private void SpawnDefender()
    {
        GameObject defender = Instantiate(Button.selectedDefender, SnapToGrid(CalculateWorldPointsOfMouseClick(Input.mousePosition)), Quaternion.identity) as GameObject;
        defender.transform.parent = defenderParent.transform;
    }

    Vector2 SnapToGrid(Vector2 mouseClickInWorldUnitsPosition)
    {
        return new Vector2(Mathf.Round(mouseClickInWorldUnitsPosition.x), Mathf.Round(mouseClickInWorldUnitsPosition.y));
    }

    Vector2 CalculateWorldPointsOfMouseClick(Vector3 mousePosition)
    {
        //var v3 = camera.ScreenToWorldPoint(mousePosition);
        Vector2 v2 = camera.ScreenToWorldPoint(mousePosition);
        //v2 = v3;
        //Debug.Log("X cordinate " + Mathf.Round(v2.x) + " Y cordinate " + Mathf.Round(v2.y));
        return v2;
    }
}
