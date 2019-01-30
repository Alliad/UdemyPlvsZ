using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    [SerializeField] private float standingThreshold = 3f;
    
    

    
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(name + IsStanding());
    }

    public bool IsStanding()
    {
        if (Mathf.Abs (transform.eulerAngles.x) > standingThreshold || 
            Mathf.Abs (transform.eulerAngles.z) > standingThreshold)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}
