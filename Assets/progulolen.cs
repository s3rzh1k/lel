using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{
    public class progulolen : MonoBehaviour
    {
        public GameObject bear;
        public GameObject bear1;
        public GameObject bear2;
        public GameObject bear3;
        public GameObject bear4;
        public Transform popa;
        public Transform pos3;
        // Use this for initialization
        void Start()
        {

        }

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Olen")
            {
                popa = pos3;
                bear.GetComponent<NaMesh>().target = popa;
                bear.GetComponent<Animation>().Play("walk");
                bear.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                bear.GetComponentInChildren<umniolen>().gulat = pos3;
                //bear.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                //agent.SetDestination(target.position);
            }
            else if (other.tag == "Olen1")
            {
                popa = pos3;
                bear1.GetComponent<NaMesh>().target = popa;
                bear1.GetComponent<Animation>().Play("walk");
                bear1.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                bear1.GetComponentInChildren<umniolen>().gulat = pos3;
            }
            else if (other.tag == "Olen2")
            {
                popa = pos3;
                bear2.GetComponent<NaMesh>().target = popa;
                bear2.GetComponent<Animation>().Play("walk");
                bear2.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                bear2.GetComponentInChildren<umniolen>().gulat = pos3;
            }
            else if (other.tag == "Olen3")
            {
                popa = pos3;
                bear3.GetComponent<NaMesh>().target = popa;
                bear3.GetComponent<Animation>().Play("walk");
                bear3.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                bear3.GetComponentInChildren<umniolen>().gulat = pos3;
            }
            else if (other.tag == "Olen4")
            {
                popa = pos3;
                bear4.GetComponent<NaMesh>().target = popa;
                bear4.GetComponent<Animation>().Play("walk");
                bear4.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                bear4.GetComponentInChildren<umniolen>().gulat = pos3;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}