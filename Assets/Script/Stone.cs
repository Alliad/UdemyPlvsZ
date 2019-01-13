using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {

    private Animator myAnimatorController;

    // Use this for initialization
	void Start () {
        myAnimatorController = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Gravestone animation in action");
        myAnimatorController.SetTrigger("underAttackTrigger");
    }

}
