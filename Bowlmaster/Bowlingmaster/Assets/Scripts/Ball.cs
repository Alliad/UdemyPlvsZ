using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour {

    private Rigidbody ballRB;
    private AudioSource myAudioSource;
    [SerializeField] private Vector3 force;
    
    
    
    // Use this for initialization
	void Start () {

        ballRB = GetComponent<Rigidbody>();
        myAudioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ballRB.AddForce(force.x, force.y, force.z, ForceMode.Impulse);
            myAudioSource.Play();
        }
	}

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Floar")
        {
            myAudioSource.Play();
        }
    }*/
}
