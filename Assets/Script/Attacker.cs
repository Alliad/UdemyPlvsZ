using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {

    private float currentSpeed;

    GameObject currentTarget;
    Animator animator;
    
    // Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
        if (!currentTarget)
        {
            animator.SetBool("isAttacking", false);
        }

        //Debug.Log(Button.selectedDefender);
	}

    /*private void OnTriggerEnter2D()
    {
        Debug.Log(name + " on treggering");
    }*/

    public void SetSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void StrikeCurrentTarget(float damage)
    {
        Debug.Log(" Applay +" + damage + " damage to the " + currentTarget.name + " from " + name);
        
        currentTarget.GetComponent<Health>().AplayDamage(damage);        
    }

    public void Attack(GameObject gameObject)
    {
        currentTarget = gameObject;
    }
}
