using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idleukabana : MonoBehaviour {
    public GameObject caban;
	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "Boar") || (other.tag == "Boar1") || (other.tag == "Boar2") || (other.tag == "Boar3") || (other.tag == "Boar4"))
        {
            caban.GetComponent<Animation>().Play("idle1");
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
