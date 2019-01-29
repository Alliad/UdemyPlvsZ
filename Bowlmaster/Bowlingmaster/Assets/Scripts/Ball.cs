using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour {

    public bool inPlay;
    private Rigidbody ballRB;
    private AudioSource myAudioSource;
    [SerializeField] private Vector3 force;
    [SerializeField] private float impulseMultiplyer;



    // Use this for initialization
    void Start () {
        inPlay = false;
        ballRB = GetComponent<Rigidbody>();
        myAudioSource = GetComponent<AudioSource>();
        ballRB.useGravity = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LaunchTheBall(force);
        }
    }

    public void LaunchTheBall(Vector3 startForce)
    {
        inPlay = true;
        ballRB.useGravity = true;
        ballRB.AddForce(startForce.x, startForce.y, impulseMultiplyer * startForce.z, ForceMode.Impulse);
        myAudioSource.Play();
    }


    /*private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Floar")
        {
            myAudioSource.Play();
        }
    }*/
}
