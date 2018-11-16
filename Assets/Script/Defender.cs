using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour {

	private void OnTriggerEnter2D()
    {
        Debug.Log(name + " on treggering");
    }
}
