using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    public GameObject projectile;
    public GameObject gun;
    private GameObject projectileParent;
    private Animator animator;
    private AttackerSpawner myLanerSpawner;

    private void Start()
    {
        projectileParent = GameObject.Find("Projectiles");

        if (!projectileParent)
        {
            projectileParent = new GameObject("Projectiles");
        }

        animator = GetComponent<Animator>();
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

    private void SetMyLaneSpawner()
    {
        var spawners[] = GameObject.FindObjectsOfType<AttackerSpawner>();
        //Transform[] allAttackerSpawners = spawners.GetComponentInChildren<Transform>();

        foreach (GameObject lanerSpawner in allAttackerSpawners)
        {

        }
    }

    private bool IsAttackerAheadInLane()
    {

        return false;
    }

    private void Fire()
    {
        GameObject newProjectile = Instantiate (projectile) as GameObject;
        newProjectile.transform.parent = projectileParent.transform;
        newProjectile.transform.position = gun.transform.position;
    }

    
}
