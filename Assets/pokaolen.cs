using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityEngine
{

    public class pokaolen : MonoBehaviour
    {
        public GameObject caban, bear, bear1, bear2, bear3, bear4;
        public Transform spawn;
        public int k, k1, k2, k3, k4;
        public bool j, j1, j2, j3, j4;
        // Use this for initialization
        void Start()
        {
            k = 0; j = false;
            k1 = 0; j1 = false;
            k2 = 0; j2 = false;
            k3 = 0; j3 = false;
            k4 = 0; j4 = false;
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Bear")
            {
                k = 0; j = true;
                caban.GetComponentInChildren<umniolen>().enabled = false;
                bear.GetComponentInChildren<IntellectCol>().enabled = false;
                bear.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                if (!bear.GetComponent<Animation>().IsPlaying("4LegsClawsAttackR"))
                    bear.GetComponent<Animation>().Play("4LegsClawsAttackR");
                if (!caban.GetComponent<Animation>().IsPlaying("death"))
                    caban.GetComponent<Animation>().Play("death");
                k++;
                bear.GetComponent<NaMesh>().target = bear.GetComponentInChildren<umniolen>().gulat;
                /* caban.GetComponent<Transform>().position = spawn.transform.position;
                 bear.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                 caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                 bear.GetComponent<NaMesh>().target = bear.GetComponentInChildren<umniolen>().gulat;
                 bear.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                 bear.GetComponent<Animation>().Play("walk");
                 caban.GetComponentInChildren<umniolen>().enabled = true;
                 bear.GetComponentInChildren<IntellectCol>().enabled = true;*/
            }
            else if (other.tag == "Bear1")
            {
                k1 = 0; j1 = true;
                caban.GetComponentInChildren<umniolen>().enabled = false;
                bear1.GetComponentInChildren<IntellectCol>().enabled = false;
                bear1.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                if (!bear1.GetComponent<Animation>().IsPlaying("4LegsClawsAttackR"))
                    bear1.GetComponent<Animation>().Play("4LegsClawsAttackR");
                if (!caban.GetComponent<Animation>().IsPlaying("death"))
                    caban.GetComponent<Animation>().Play("death");
                k1++;
                bear1.GetComponent<NaMesh>().target = bear1.GetComponentInChildren<umniolen>().gulat;
                /* caban.GetComponent<Transform>().position = spawn.transform.position;
                 bear1.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                 caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                 bear1.GetComponent<NaMesh>().target = bear1.GetComponentInChildren<umniolen>().gulat;
                 bear1.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                 bear1.GetComponent<Animation>().Play("walk");
                 caban.GetComponentInChildren<umniolen>().enabled = true;
                 bear1.GetComponentInChildren<IntellectCol>().enabled = true;*/
            }
            else if (other.tag == "Bear2")
            {
                k2 = 0; j2 = true;
                caban.GetComponentInChildren<umniolen>().enabled = false;
                bear2.GetComponentInChildren<IntellectCol>().enabled = false;
                bear2.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                if (!bear2.GetComponent<Animation>().IsPlaying("4LegsClawsAttackR"))
                    bear2.GetComponent<Animation>().Play("4LegsClawsAttackR");
                if (!caban.GetComponent<Animation>().IsPlaying("death"))
                    caban.GetComponent<Animation>().Play("death");
                k2++;
                bear2.GetComponent<NaMesh>().target = bear2.GetComponentInChildren<umniolen>().gulat;
                /* caban.GetComponent<Transform>().position = spawn.transform.position;
                 bear2.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                 caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                 bear2.GetComponent<NaMesh>().target = bear2.GetComponentInChildren<umniolen>().gulat;
                 bear2.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                 bear2.GetComponent<Animation>().Play("walk");
                 caban.GetComponentInChildren<umniolen>().enabled = true;
                 bear2.GetComponentInChildren<IntellectCol>().enabled = true;*/
            }
            else if (other.tag == "Bear3")
            {
                k3 = 0; j3 = true;
                caban.GetComponentInChildren<umniolen>().enabled = false;
                bear3.GetComponentInChildren<IntellectCol>().enabled = false;
                bear3.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                if (!bear3.GetComponent<Animation>().IsPlaying("4LegsClawsAttackR"))
                    bear3.GetComponent<Animation>().Play("4LegsClawsAttackR");
                if (!caban.GetComponent<Animation>().IsPlaying("death"))
                    caban.GetComponent<Animation>().Play("death");
               k3++;
                bear3.GetComponent<NaMesh>().target = bear3.GetComponentInChildren<umniolen>().gulat;
                /* caban.GetComponent<Transform>().position = spawn.transform.position;
                 bear3.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                 caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                 bear3.GetComponent<NaMesh>().target = bear3.GetComponentInChildren<umniolen>().gulat;
                 bear3.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                 bear3.GetComponent<Animation>().Play("walk");
                 caban.GetComponentInChildren<umniolen>().enabled = true;
                 bear3.GetComponentInChildren<IntellectCol>().enabled = true;*/
                // k3++; j3 = false;
            }
            else if (other.tag == "Bear4")
            {
                k4 = 0; j4 = true;
                caban.GetComponentInChildren<umniolen>().enabled = false;
                bear4.GetComponentInChildren<IntellectCol>().enabled = false;
                bear4.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                if (!bear4.GetComponent<Animation>().IsPlaying("4LegsClawsAttackR"))
                    bear4.GetComponent<Animation>().Play("4LegsClawsAttackR");
                if (!caban.GetComponent<Animation>().IsPlaying("death"))
                    caban.GetComponent<Animation>().Play("death");
                k4++;
                bear4.GetComponent<NaMesh>().target = bear4.GetComponentInChildren<umniolen>().gulat;
                /* caban.GetComponent<Transform>().position = spawn.transform.position;
                 bear4.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                 caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                 bear4.GetComponent<NaMesh>().target = bear4.GetComponentInChildren<umniolen>().gulat;
                 bear4.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                 bear4.GetComponent<Animation>().Play("walk");
                 caban.GetComponentInChildren<umniolen>().enabled = true;
                 bear4.GetComponentInChildren<IntellectCol>().enabled = true;*/

            }
        }
        // Update is called once per frame
        void Update()
        {
            if (caban.GetComponent<Animation>().IsPlaying("death"))
            {
                /*   if (j == true) { k++; }
                   else if (j1 == true) { k1++; }
                   else if (j2 == true) { k2++; }
                   else if (j3 == true) { k3++; }
                   else if (j4 == true) { k4++; }*/
                //  }
                if ((k > 0) && (k < 52))
                {
                    caban.GetComponent<Transform>().position = spawn.transform.position;
                    bear.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                    caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                    bear.GetComponent<NaMesh>().target = bear.GetComponentInChildren<umniolen>().gulat;
                    bear.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                    bear.GetComponent<Animation>().Play("walk");
                    caban.GetComponentInChildren<umniolen>().enabled = true;
                    bear.GetComponentInChildren<IntellectCol>().enabled = true;
                    k++; j = false;
                }
                if ((k1 > 0) && (k1 < 52))
                {
                    caban.GetComponent<Transform>().position = spawn.transform.position;
                    bear1.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                    caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                    bear1.GetComponent<NaMesh>().target = bear1.GetComponentInChildren<umniolen>().gulat;
                    bear1.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                    bear1.GetComponent<Animation>().Play("walk");
                    caban.GetComponentInChildren<umniolen>().enabled = true;
                    bear1.GetComponentInChildren<IntellectCol>().enabled = true;
                    k1++; j1 = false;
                }
                if ((k2 > 0) && (k2 < 52))
                {
                    caban.GetComponent<Transform>().position = spawn.transform.position;
                    bear2.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                    caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                    bear2.GetComponent<NaMesh>().target = bear2.GetComponentInChildren<umniolen>().gulat;
                    bear2.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                    bear2.GetComponent<Animation>().Play("walk");
                    caban.GetComponentInChildren<umniolen>().enabled = true;
                    bear2.GetComponentInChildren<IntellectCol>().enabled = true;
                    k2++; j2 = false;
                }
                if ((k3 > 0) && (k3 < 52))
                {
                    caban.GetComponent<Transform>().position = spawn.transform.position;
                    bear3.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                    caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                    bear3.GetComponent<NaMesh>().target = bear3.GetComponentInChildren<umniolen>().gulat;
                    bear3.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                    bear3.GetComponent<Animation>().Play("walk");
                    caban.GetComponentInChildren<umniolen>().enabled = true;
                    bear3.GetComponentInChildren<IntellectCol>().enabled = true;
                    k3++; j3 = false;
                }
                if ((k4 > 0) && (k4 < 52))
                {
                    caban.GetComponent<Transform>().position = spawn.transform.position;
                    bear4.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                    caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                    bear4.GetComponent<NaMesh>().target = bear4.GetComponentInChildren<umniolen>().gulat;
                    bear4.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                    bear4.GetComponent<Animation>().Play("walk");
                    caban.GetComponentInChildren<umniolen>().enabled = true;
                    bear4.GetComponentInChildren<IntellectCol>().enabled = true;
                    k4++; j4 = false;
                }
            }
        }
    }
}