using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour {

    private Rigidbody ballRB;
    private AudioSource myAudioSource;
    [SerializeField] private Vector3 force;
    [SerializeField] private float impulseMultiplyer;



    // Use this for initialization
    void Start () {

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
        ballRB.useGravity = true;
        ballRB.AddForce(impulseMultiplyer * startForce.x, startForce.y, impulseMultiplyer * startForce.z, ForceMode.Impulse);
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
