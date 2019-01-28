using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Ball))]

public class DrugLaunch : MonoBehaviour
{
    private Vector3 dragStart;
    private Vector3 dragEnd;
    private float startTime;
    private float endTime;
    private Ball ball;
    
    
    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Ball>();
    }

    // Update is called once per frame
    /*void Update()
    {
        Debug.Log("Update dragStart.x " + dragStart.x);
    }*/

    public void DragStart()
    {
        dragStart = Input.mousePosition;
        Debug.Log("dragStart.x " + dragStart.x);
        startTime = Time.time;
        Debug.Log("startTime " + startTime);
        Debug.Log(startTime);
    }

    public void DragEnd()
    {
        Debug.Log("startTime " + startTime);
        dragEnd = Input.mousePosition;
        Debug.Log("dragEnd.x " + dragEnd.x);
        Debug.Log("dragStart.x " + dragStart.x);
        endTime = Time.time;
        Debug.Log(endTime);
        float dragDuration = endTime - startTime;
        float dragDistanceZ = (dragEnd.y - dragStart.y);
        float launchImpulsZ = dragDistanceZ / dragDuration;
        Debug.Log("dragStart.x " + dragStart.x);
        float dragDictanceX = (dragEnd.x - dragStart.x);
        Debug.Log("dragDictanceX " + dragDictanceX);
        float launchImpulsX = dragDictanceX / dragDuration;
        Debug.Log("(dragEnd.x - dragStart.x) " + (dragEnd.x - dragStart.x));

        Debug.Log("launchImpulsX " + launchImpulsX);
        Debug.Log("launchImpulsZ " + launchImpulsZ);

        //Debug.Log("end - Start " + (dragEnd - dragStart));
        //Debug.Log("Velocity " + velocity);

        ball.LaunchTheBall(new Vector3(launchImpulsX, 0f, launchImpulsZ));
    }
}
