using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{
    public class otkldeath : MonoBehaviour
    {
        public GameObject caban;
        public GameObject bear;
        public Transform spawn;
        // Use this for initialization
        void Start()
        {
            
        }

        void Pisos()
        {
            caban.GetComponentInChildren<deathkaban>().enabled = false;
            caban.GetComponent<Transform>().position = spawn.transform.position;
            bear.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
            caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
            caban.GetComponentInChildren<deathkaban>().enabled = true;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}