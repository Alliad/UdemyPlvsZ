using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private float standingThreshold = 50f;
    
    

    
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(name + IsStanding());
    }

    public bool IsStanding()
    {
        
        //Debug.Log("Pin name " + name + " transform.eulerAngles.x " + Mathf.Abs(transform.rotation.eulerAngles.x) + " and transform.eulerAngles.z " + Mathf.Abs(transform.rotation.eulerAngles.z));
        if (Mathf.Abs (transform.rotation.eulerAngles.x) > standingThreshold || 
            Mathf.Abs (transform.rotation.eulerAngles.z) > standingThreshold)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}
