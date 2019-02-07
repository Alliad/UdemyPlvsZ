using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    [SerializeField] private GameObject ball;

    // Offset betwine main camera and the ball
    private float offset;
    private Vector3 cameraPosition;
    private float stopPozition = 1800f; 
    
    // Use this for initialization
	void Start () {
        offset = ball.transform.position.z - transform.position.z;
        cameraPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        //Debug.Log(offset);
    }
	
	// Update is called once per frame
	void Update () {

        if (ball.transform.position.z <= stopPozition)
        {
            cameraPosition.z = ball.transform.position.z - offset;
            transform.position = cameraPosition;
        }
        


    }
}
