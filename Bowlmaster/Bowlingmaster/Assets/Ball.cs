using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour {

    private Rigidbody ballRB;
    private AudioSource myAudioSource;
    [SerializeField] private float impulse;
    
    
    
    // Use this for initialization
	void Start () {

        ballRB = GetComponent<Rigidbody>();
        myAudioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ballRB.AddForce(0, 0, impulse, ForceMode.Impulse);
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
