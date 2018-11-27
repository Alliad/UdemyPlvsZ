using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    SpriteRenderer buttonSpriteRenderer;
    
    // Use this for initialization
	void Start () {
        buttonSpriteRenderer = GetComponent<SpriteRenderer>();
        buttonSpriteRenderer.color = Color.black;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        Debug.Log(gameObject.name + " pressed");
        buttonSpriteRenderer.color = Color.white;
    }
}
