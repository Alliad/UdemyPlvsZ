using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Ball))]

public class DrugLaunch : MonoBehaviour
{
    private Ball ball;
    
    
    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DragStart()
    {

    }

    public void DragEnd()
    {

    }
}
