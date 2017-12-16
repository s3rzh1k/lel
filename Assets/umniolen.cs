using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

    public class umniolen : MonoBehaviour
    {

        public GameObject olen;
        public Transform home,gulat,boar,boar1,boar2,boar3,boar4;
        // Use this for initialization
        void Start()
        {

        }

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Pisos")
            {
                olen.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                olen.GetComponent<NaMesh>().target = home;
                olen.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 7;
                olen.GetComponent<Animation>().Play("walk");
            }
            else if ((other.tag == "Bear") || (other.tag == "Bear1") || (other.tag == "Bear2") || (other.tag == "Bear3") || (other.tag == "Bear4"))
            {
                olen.GetComponent<NaMesh>().target = home;
                olen.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 7;
                olen.GetComponent<Animation>().Play("walk");
            }
            if (other.tag == "Boar")
            {
                olen.GetComponent<NaMesh>().target = boar;
                olen.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 7;
                olen.GetComponent<Animation>().Play("walk");
            }
            else if (other.tag == "Boar1")
            {
                olen.GetComponent<NaMesh>().target = boar1;
                olen.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 7;
                olen.GetComponent<Animation>().Play("walk");
            }
            else if (other.tag == "Boar2")
            {
                olen.GetComponent<NaMesh>().target = boar2;
                olen.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 7;
                olen.GetComponent<Animation>().Play("walk");
            }
            else if (other.tag == "Boar3")
            {
                olen.GetComponent<NaMesh>().target = boar3;
                olen.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 7;
                olen.GetComponent<Animation>().Play("walk");
            }
            else if (other.tag == "Boar4")
            {
                olen.GetComponent<NaMesh>().target = boar4;
                olen.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 7;
                olen.GetComponent<Animation>().Play("walk");
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (other.tag == "Pisos")
            {
                olen.GetComponent<NaMesh>().target = gulat;
                olen.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 5;
                olen.GetComponent<Animation>().Play("walk");
            }
            else if ((other.tag == "Bear") || (other.tag == "Bear1") || (other.tag == "Bear2") || (other.tag == "Bear3") || (other.tag == "Bear4"))
            {
                olen.GetComponent<NaMesh>().target = gulat;
                olen.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 5;
                olen.GetComponent<Animation>().Play("walk");
            }
            else if ((other.tag == "Boar") || (other.tag == "Boar1") || (other.tag == "Boar2") || (other.tag == "Boar3") || (other.tag == "Boar4"))
            {
                olen.GetComponent<NaMesh>().target = gulat;
                olen.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 5;
                olen.GetComponent<Animation>().Play("walk");
            }
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}