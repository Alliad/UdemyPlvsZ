using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    SpriteRenderer buttonSpriteRenderer;
    [SerializeField] GameObject buttonController;
    
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
        buttonController.GetComponent<ButtonsController>().SwitchButtons(gameObject.name);
    }
}
