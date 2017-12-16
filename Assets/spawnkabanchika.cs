using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{


    public class spawnkabanchika : MonoBehaviour
    {
        public GameObject caban;
        public GameObject caban1;
        public GameObject caban2;
        public GameObject caban3;
        public GameObject caban4;
        // Use this for initialization
        void Start()
        {

        }

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Boar")
            {
                caban.GetComponent<NaMesh>().target = caban.GetComponentInChildren<KabanCol>().idle;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                caban.GetComponent<Animation>().Play("walk");
            }
            else if (other.tag == "Boar1")
            {
                caban1.GetComponent<NaMesh>().target = caban1.GetComponentInChildren<KabanCol>().idle;
                caban1.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                caban1.GetComponent<Animation>().Play("walk");
            }
            else if (other.tag == "Boar2")
            {
                caban2.GetComponent<NaMesh>().target = caban2.GetComponentInChildren<KabanCol>().idle;
                caban2.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                caban2.GetComponent<Animation>().Play("walk");
            }
            else if (other.tag == "Boar3")
            {
                caban3.GetComponent<NaMesh>().target = caban3.GetComponentInChildren<KabanCol>().idle;
                caban3.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                caban3.GetComponent<Animation>().Play("walk");
            }
            else if (other.tag == "Boar4")
            {
                caban4.GetComponent<NaMesh>().target = caban4.GetComponentInChildren<KabanCol>().idle;
                caban4.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                caban4.GetComponent<Animation>().Play("walk");
            }
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}