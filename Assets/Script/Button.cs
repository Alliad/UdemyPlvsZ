using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    public GameObject defenderPrefab;
    public static GameObject selectedDefender;
    SpriteRenderer buttonSpriteRenderer;
    [SerializeField] ButtonsController buttonController;
    
    
    // Use this for initialization
	void Start () {
        buttonSpriteRenderer = GetComponent<SpriteRenderer>();
        buttonSpriteRenderer.color = Color.black;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    internal void DrawButtonToColor(Color buttonColor)
    {
        buttonSpriteRenderer.color = buttonColor;
    }

    private void OnMouseDown()
    {
        //Debug.Log(gameObject.name + " pressed");
        DrawButtonToColor(Color.white);
        buttonController.SwitchButtons(gameObject.name);
        selectedDefender = defenderPrefab;
    }
}
