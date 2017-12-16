using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

    public class homeolezhi : MonoBehaviour
    {
        public GameObject olen, olen1, olen2, olen3, olen4;
        // Use this for initialization
        void Start()
        {

        }

        void OnTriggerEnter (Collider other)
        {
            if (other.tag == "Olen")
            {
                olen.GetComponent<NaMesh>().target = olen.GetComponentInChildren<umniolen>().gulat;
                olen.GetComponent<Animation>().Play("walk");
                olen.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
            }
            else if (other.tag == "Olen1")
            {
                olen1.GetComponent<NaMesh>().target = olen1.GetComponentInChildren<umniolen>().gulat;
                olen1.GetComponent<Animation>().Play("walk");
                olen1.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
            }
            else if (other.tag == "Olen2")
            {
                olen2.GetComponent<NaMesh>().target = olen2.GetComponentInChildren<umniolen>().gulat;
                olen2.GetComponent<Animation>().Play("walk");
                olen2.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
            }
            else if (other.tag == "Olen3")
            {
                olen3.GetComponent<NaMesh>().target = olen3.GetComponentInChildren<umniolen>().gulat;
                olen3.GetComponent<Animation>().Play("walk");
                olen3.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
            }
            else if (other.tag == "Olen4")
            {
                olen4.GetComponent<NaMesh>().target = olen4.GetComponentInChildren<umniolen>().gulat;
                olen4.GetComponent<Animation>().Play("walk");
                olen4.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
