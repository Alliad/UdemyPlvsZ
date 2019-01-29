using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Ball))]

public class DrugLaunch : MonoBehaviour
{
    private Vector3 dragStart;
    private Vector3 dragEnd;
    private Vector3 horizontalMoveStart;
    private Vector3 horizontalMoveFinish;
    private float startTime;
    private float endTime;
    private bool onDrag;
    private Ball ball;
    
    
    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Ball>();
        onDrag = false;
    }

    private void Update()
    {
       
    }

    public void DragStart()
    {
        dragStart = Input.mousePosition;
        
        startTime = Time.time;
        
    }

    public void DragEnd()
    {        
        dragEnd = Input.mousePosition;
        
        endTime = Time.time;
        
        float dragDuration = endTime - startTime;
        float launchImpulsZ = (dragEnd.y - dragStart.y) / dragDuration;
        float launchImpulsX = (dragEnd.x - dragStart.x) / dragDuration;
        
        ball.LaunchTheBall(new Vector3(launchImpulsX, 0f, launchImpulsZ));
    }

    public void MoveStart(float amount)
    {
        if (!ball.inPlay)
        {
            transform.Translate(new Vector3(amount, 0, 0)); //= new Vector3(transform.position.x + amount, transform.position.y, transform.position.z);            
        }
        
    }
}
