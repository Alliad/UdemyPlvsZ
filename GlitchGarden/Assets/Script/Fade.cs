using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour {

    Image image;
    Color tempColor;
    [Range(0f, 10f)] [SerializeField] float fadeInTime;
    
    
	
    // Use this for initialization
	void Start () {
        image = GetComponent<Image>();
        tempColor = new Color(image.color.r, image.color.g, image.color.b, 1f);
        image.color = tempColor;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeSinceLevelLoad < fadeInTime)
        {
            tempColor.a -= Time.deltaTime / fadeInTime;
            image.color = tempColor;
        }
        else
        {
            gameObject.SetActive(false);
        }
	}
}
