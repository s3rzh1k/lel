using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

    public class IntellectCol : MonoBehaviour
    {
        public GameObject bear;
        public Transform popa;
        public Transform home;
        public Transform chelik;
        public Transform kaban;
        public Transform kaban1;
        public Transform kaban2;
        public Transform kaban3;
        public Transform kaban4, olen,olen1,olen2,olen3,olen4;
        //UnityEngine.AI.NavMeshAgent agent;

        // Use this for initialization
        void Start()
        {
            //agent = bear.GetComponent<UnityEngine.AI.NavMeshAgent>();
            //agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        }

        
        // Update is called once per frame
        void Update()
        {
            //agent.SetDestination(target.position);
            
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Pisos")
            {
                bear.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                popa = chelik;
                bear.GetComponent<NaMesh>().target = popa;
                bear.GetComponent<Animation>().Play("run");
                bear.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 5;
                //bear.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                //agent.SetDestination(target.position);
            }
            else if(other.tag == "Boar")
            {
                popa = kaban;
                bear.GetComponent<NaMesh>().target = popa;
                bear.GetComponent<Animation>().Play("run");
                bear.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 9;
            }
            else if (other.tag == "Boar1")
            {
                popa = kaban1;
                bear.GetComponent<NaMesh>().target = popa;
                bear.GetComponent<Animation>().Play("run");
                bear.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 9;
            }
            else if (other.tag == "Boar2")
            {
                popa = kaban2;
                bear.GetComponent<NaMesh>().target = popa;
                bear.GetComponent<Animation>().Play("run");
                bear.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 9;
            }
            else if (other.tag == "Boar3")
            {
                popa = kaban3;
                bear.GetComponent<NaMesh>().target = popa;
                bear.GetComponent<Animation>().Play("run");
                bear.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 9;
            }
            else if (other.tag == "Boar4")
            {
                popa = kaban4;
                bear.GetComponent<NaMesh>().target = popa;
                bear.GetComponent<Animation>().Play("run");
                bear.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 9;
            }
            else if (other.tag == "Olen")
            {
                popa = olen;
                bear.GetComponent<NaMesh>().target = popa;
                bear.GetComponent<Animation>().Play("run");
                bear.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 9;
            }
            else if (other.tag == "Olen1")
            {
                popa = olen1;
                bear.GetComponent<NaMesh>().target = popa;
                bear.GetComponent<Animation>().Play("run");
                bear.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 9;
            }
            else if (other.tag == "Olen2")
            {
                popa = olen2;
                bear.GetComponent<NaMesh>().target = popa;
                bear.GetComponent<Animation>().Play("run");
                bear.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 9;
            }
            else if (other.tag == "Olen3")
            {
                popa = olen3;
                bear.GetComponent<NaMesh>().target = popa;
                bear.GetComponent<Animation>().Play("run");
                bear.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 9;
            }
            else if (other.tag == "Olen4")
            {
                popa = olen4;
                bear.GetComponent<NaMesh>().target = popa;
                bear.GetComponent<Animation>().Play("run");
                bear.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 9;
            }
        }  

        void OnTriggerExit(Collider other)
        {
            if ((other.tag == "Pisos")||(other.tag == "Boar"))
            {
                popa = home;
                bear.GetComponent<NaMesh>().target = popa;
                bear.GetComponent<Animation>().Play("walk");
                bear.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                //agent.SetDestination(target.position);
            }
        }

    }
}


