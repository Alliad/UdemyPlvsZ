using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour {

    public GameObject defenderPrefab;
    public static GameObject selectedDefender;
    SpriteRenderer buttonSpriteRenderer;
    [SerializeField] ButtonsController buttonController;
    private Text coastText;
    
    
    // Use this for initialization
	void Start () {
        buttonSpriteRenderer = GetComponent<SpriteRenderer>();
        buttonSpriteRenderer.color = Color.black;
        if (GetComponentInChildren<Text>())
        {
            coastText = GetComponentInChildren<Text>();
        }
        else
        {
            Debug.LogWarning("Can't find Text component");
        }

        coastText.text = defenderPrefab.GetComponent<Defender>().starCoast.ToString();        
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
