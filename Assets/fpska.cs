﻿using UnityEngine;
using System.Collections;

public class fpska : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnGUI()
    {
        float fps = 1.0f / Time.deltaTime;
        GUILayout.Label("FPS = " + fps);
    }
}
