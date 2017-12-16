﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

    public class NaMesh : MonoBehaviour
    {

        public Transform target;
        UnityEngine.AI.NavMeshAgent agent;

        // Use this for initialization
        void Start()
        {
            agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

        }

        // Update is called once per frame
        void Update()
        {

            agent.SetDestination(target.position);

        }
    }
}