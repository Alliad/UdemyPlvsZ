using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Attacker))]
public class Fox : MonoBehaviour {

    Animator animator;
    Attacker attacker;
    
    // Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        attacker = GetComponent<Attacker>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject obj = collision.gameObject;

        if (obj.GetComponent<Attacker>())
        {
            //Debug.Log("Fox collied with attacker");
            return;
        }

        if (obj.GetComponent<Stone>())
        {

            animator.SetTrigger("jumpTrigger");
        }
        else
        {
            //Debug.Log("Fox triggering with " + collision.name + " in fox.cs");
            animator.SetBool("isAttacking", true);
            attacker.Attack(obj);
        }
    }
}
