using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

    public class KabanCol : MonoBehaviour
    {
        public GameObject kaban;
        public Transform popa;
        public Transform home;
        public Transform idle;
        public Transform chelik, olen, olen1, olen2, olen3, olen4;
        // public Transform bear;
        //UnityEngine.AI.NavMeshAgent agent;

        // Use this for initialization
        void Start()
        {
            //agent = bear.GetComponent<UnityEngine.AI.NavMeshAgent>();
            //agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        }


        // Update is called once per frame


        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Pisos")
            {
                kaban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                popa = chelik;
                kaban.GetComponent<NaMesh>().target = popa;
                kaban.GetComponent<Animation>().Play("run");
                kaban.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 5;
                //bear.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                //agent.SetDestination(target.position);
            }
            else if ((other.tag == "Bear") || (other.tag == "Bear1") || (other.tag == "Bear2") || (other.tag == "Bear3") || (other.tag == "Bear4"))
            {
                popa = home;
                kaban.GetComponent<NaMesh>().target = popa;
                kaban.GetComponent<Animation>().Play("run");
                kaban.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 7;
            }
            else if ((other.tag == "Olen") || (other.tag == "Olen1") || (other.tag == "Olen2") || (other.tag == "Olen3") || (other.tag == "Olen4"))
            {
                popa = home;
                kaban.GetComponent<NaMesh>().target = popa;
                kaban.GetComponent<Animation>().Play("run");
                kaban.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 5;
            }
            /* else if (other.tag == "Olen")
             {
                 popa = olen;
                 kaban.GetComponent<NaMesh>().target = popa;
                 kaban.GetComponent<Animation>().Play("run");
                 kaban.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 5;
             }
             else if (other.tag == "Olen1")
             {
                 popa = olen1;
                 olen1.GetComponent<NaMesh>().target = popa;
                 olen1.GetComponent<Animation>().Play("run");
                 olen1.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 5;
             }
             else if (other.tag == "Olen2")
             {
                 popa = olen2;
                 kaban.GetComponent<NaMesh>().target = popa;
                 kaban.GetComponent<Animation>().Play("run");
                 kaban.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 5;
             }
             else if (other.tag == "Olen3")
             {
                 popa = olen3;
                 kaban.GetComponent<NaMesh>().target = popa;
                 kaban.GetComponent<Animation>().Play("run");
                 kaban.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 5;
             }
             else if (other.tag == "Olen4")
             {
                 popa = olen4;
                 kaban.GetComponent<NaMesh>().target = popa;
                 kaban.GetComponent<Animation>().Play("run");
                 kaban.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 5;
             }*/
        }

        void OnTriggerExit(Collider other)
        {
            if ((other.tag == "Pisos") || (other.tag == "Bear") || (other.tag == "Bear1") || (other.tag == "Bear2") || (other.tag == "Bear3") || (other.tag == "Bear4") || (other.tag == "Olen") || (other.tag == "Olen1") || (other.tag == "Olen2") || (other.tag == "Olen3") || (other.tag == "Olen4"))
            {
                popa = idle;
                kaban.GetComponent<NaMesh>().target = popa;
                kaban.GetComponent<Animation>().Play("walk");
                kaban.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                //agent.SetDestination(target.position);
            }
        }

        void Update()
        {
            //agent.SetDestination(target.position);
            
        }
    }
}
