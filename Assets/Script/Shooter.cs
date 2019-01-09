using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    public GameObject projectile;
    public GameObject gun;
    private GameObject projectileParent;
    private Animator animator;
    private AttackerSpawner myLaneSpawner;

    private void Start()
    {
        animator = GetComponent<Animator>();
        projectileParent = GameObject.Find("Projectiles");

        if (!projectileParent)
        {
            projectileParent = new GameObject("Projectiles");
        }

        SetMyLaneSpawner();
        print(myLaneSpawner);
    }

    private void Update()
    {
        if (IsAttackerAheadInLane())
        {
            animator.SetBool("isAttacking", true);
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }
    // Look through all spawners, and set myLaneSpawner if found
    private void SetMyLaneSpawner()
    {
        AttackerSpawner[] spawnerArray = GameObject.FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner attackerSpawner in spawnerArray)
        {
            Debug.Log(attackerSpawner.name + "  " + attackerSpawner.transform.position.y);
            Debug.Log(name + "  " + transform.position.y);
            if (attackerSpawner.transform.position.y == transform.position.y)
            {
                myLaneSpawner = attackerSpawner;
                return;
            }
            
                Debug.LogError(name + " can't find spawner on his line");
            
        }
    }

    private bool IsAttackerAheadInLane()
    {

        return true;
    }

    private void Fire()
    {
        GameObject newProjectile = Instantiate (projectile) as GameObject;
        newProjectile.transform.parent = projectileParent.transform;
        newProjectile.transform.position = gun.transform.position;
    }

    
}
