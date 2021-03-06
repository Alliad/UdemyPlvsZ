﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float speed;
    public float damage;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject obj = collision.gameObject;

        if (collision.name == "Shreder")
        {
            Destroy(gameObject);
        }

        if (obj.GetComponent<Attacker>())
        {
            obj.GetComponent<Health>().AplayDamage(damage);
            Destroy(gameObject);
        }
    }
}
