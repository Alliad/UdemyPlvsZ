using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    public GameObject projectile;
    public GameObject projectileParent;
    public GameObject gun;

    private void Fire()
    {
        GameObject newProjectile = Instantiate(projectile, gun.transform.position, gun.transform.rotation) as GameObject;
        //newProjectile.
    }

    
}
