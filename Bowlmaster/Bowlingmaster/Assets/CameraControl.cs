using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    [SerializeField] private GameObject ball;

    // Offset betwine main camera and the ball
    private Vector3 offset;
    private Vector3 cameraPosition;
    private float stopPozition = 1800; 
    
    // Use this for initialization
	void Start () {
        offset = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, ball.transform.position.z - gameObject.transform.position.z);
        Debug.Log(offset);
    }
	
	// Update is called once per frame
	void Update () {

        if (ball.transform.position.z <= stopPozition)
        {
            gameObject.transform.position = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, ball.transform.position.z - offset.z);
        }
        


    }
}
