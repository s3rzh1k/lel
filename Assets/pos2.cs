using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{
    public class pos2 : MonoBehaviour
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
            if (other.tag == "Bear")
            {
                popa = pos3;
                bear.GetComponent<NaMesh>().target = popa;
                bear.GetComponent<Animation>().Play("walk");
                bear.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                bear.GetComponentInChildren<IntellectCol>().home = pos3;
                //bear.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                //agent.SetDestination(target.position);
            }
            else if (other.tag == "Bear1")
            {
                popa = pos3;
                bear1.GetComponent<NaMesh>().target = popa;
                bear1.GetComponent<Animation>().Play("walk");
                bear1.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                bear1.GetComponentInChildren<IntellectCol>().home = pos3;
            }
            else if (other.tag == "Bear2")
            {
                popa = pos3;
                bear2.GetComponent<NaMesh>().target = popa;
                bear2.GetComponent<Animation>().Play("walk");
                bear2.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                bear2.GetComponentInChildren<IntellectCol>().home = pos3;
            }
            else if (other.tag == "Bear3")
            {
                popa = pos3;
                bear3.GetComponent<NaMesh>().target = popa;
                bear3.GetComponent<Animation>().Play("walk");
                bear3.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                bear3.GetComponentInChildren<IntellectCol>().home = pos3;
            }
            else if (other.tag == "Bear4")
            {
                popa = pos3;
                bear4.GetComponent<NaMesh>().target = popa;
                bear4.GetComponent<Animation>().Play("walk");
                bear4.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                bear4.GetComponentInChildren<IntellectCol>().home = pos3;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}