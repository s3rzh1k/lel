using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;


public class Bibliovizov : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    [DllImport("Biblioteka")]
    private static extern int answer();
	// Update is called once per frame
	void Update () {
        Debug.Log(answer());
	}

    void OnGUI()
    {
        float fps = 1.0f / Time.deltaTime - 42 + answer();
        GUILayout.Label("FPS = " + fps);
    }
}
