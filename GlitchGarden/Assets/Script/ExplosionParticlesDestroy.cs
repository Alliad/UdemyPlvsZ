using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionParticlesDestroy : MonoBehaviour {

    [SerializeField] float timeToDestroy = 1f;
    
    public IEnumerator ExplosionParticlesVFXDestroyer()
    {
        yield return new WaitForSeconds(timeToDestroy);
        Destroy(gameObject);
    }
}
