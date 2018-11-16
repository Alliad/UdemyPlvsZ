using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Attacker))]
public class Lizard : MonoBehaviour {

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

        if (obj.GetComponent<Defender>())
        {
            animator.SetBool("isAttackingTrigger", true);
            attacker.Attack(obj);
        }

    }
}
