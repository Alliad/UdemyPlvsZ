using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {

    private float currentSpeed;

    GameObject currentTarget;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
	}

    private void OnTriggerEnter2D()
    {
        Debug.Log(name + " on treggering");
    }

    public void SetSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void StrikeCurrentTarget(float damage)
    {
        Debug.Log(" Applay +" + damage + " damage from " + name);
    }

    public void Attack(GameObject gameObject)
    {
        currentTarget = gameObject;
    }
}
