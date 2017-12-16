using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{
    public class deathkaban : MonoBehaviour
    {
        public GameObject bear;
        public GameObject bear1;
        public GameObject bear2;
        public GameObject bear3;
        public GameObject bear4,olen, olen1, olen2, olen3, olen4;
        public GameObject caban;
        public GameObject spawn;
        public int k,k1,k2,k3,k4,kk,kk1,kk2,kk3,kk4;
        public bool j,j1,j2,j3,j4,jj,jj1,jj2,jj3,jj4;
        // Use this for initialization
        void Start()
        {
            k = 0; j = false;
            k1 = 0; j1 = false;
            k2 = 0; j2 = false;
            k3 = 0; j3 = false;
            k4 = 0; j4 = false;
            kk = 0; jj = false;
            kk1 = 0; jj1 = false;
            kk2 = 0; jj2 = false;
            kk3 = 0; jj3 = false;
            kk4 = 0; jj4 = false;
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Bear")
            {
                k = 0; j = true;
                caban.GetComponentInChildren<KabanCol>().enabled = false;
                bear.GetComponentInChildren<IntellectCol>().enabled = false;
                bear.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                if (!bear.GetComponent<Animation>().IsPlaying("4LegsClawsAttackR"))
                    bear.GetComponent<Animation>().Play("4LegsClawsAttackR");
                if (!caban.GetComponent<Animation>().IsPlaying("death"))
                    caban.GetComponent<Animation>().Play("death");
                }
            else if (other.tag == "Bear1")
            {
                k1 = 0; j1 = true;
                caban.GetComponentInChildren<KabanCol>().enabled = false;
                bear1.GetComponentInChildren<IntellectCol>().enabled = false;
                bear1.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                if (!bear1.GetComponent<Animation>().IsPlaying("4LegsClawsAttackR"))
                    bear1.GetComponent<Animation>().Play("4LegsClawsAttackR");
                if (!caban.GetComponent<Animation>().IsPlaying("death"))
                    caban.GetComponent<Animation>().Play("death");
             }
            else if (other.tag == "Bear2")
            {
                k2 = 0; j2 = true;
                caban.GetComponentInChildren<KabanCol>().enabled = false;
                bear2.GetComponentInChildren<IntellectCol>().enabled = false;
                bear2.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                if (!bear2.GetComponent<Animation>().IsPlaying("4LegsClawsAttackR"))
                    bear2.GetComponent<Animation>().Play("4LegsClawsAttackR");
                if (!caban.GetComponent<Animation>().IsPlaying("death"))
                    caban.GetComponent<Animation>().Play("death");
                           }
            else if (other.tag == "Bear3")
            {
                k3 = 0; j3 = true;
                caban.GetComponentInChildren<KabanCol>().enabled = false;
                bear3.GetComponentInChildren<IntellectCol>().enabled = false;
                bear3.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                if (!bear3.GetComponent<Animation>().IsPlaying("4LegsClawsAttackR"))
                    bear3.GetComponent<Animation>().Play("4LegsClawsAttackR");
                if (!caban.GetComponent<Animation>().IsPlaying("death"))
                    caban.GetComponent<Animation>().Play("death");
                

            }
            else if (other.tag == "Bear4")
            {
                k4 = 0; j4 = true;
                caban.GetComponentInChildren<KabanCol>().enabled = false;
                bear4.GetComponentInChildren<IntellectCol>().enabled = false;
                bear4.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                if (!bear4.GetComponent<Animation>().IsPlaying("4LegsClawsAttackR"))
                    bear4.GetComponent<Animation>().Play("4LegsClawsAttackR");
                if (!caban.GetComponent<Animation>().IsPlaying("death"))
                    caban.GetComponent<Animation>().Play("death");
               
            }

            else

            if (other.tag == "Olen")
            {
                k = 0; j = true;
                caban.GetComponentInChildren<KabanCol>().enabled = false;
                olen.GetComponentInChildren<umniolen>().enabled = false;
                olen.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                if (!olen.GetComponent<Animation>().IsPlaying("hornAttack1"))
                    olen.GetComponent<Animation>().Play("hornAttack1");
                if (!caban.GetComponent<Animation>().IsPlaying("death"))
                    caban.GetComponent<Animation>().Play("death");
            }
            else if (other.tag == "Olen1")
            {
                k1 = 0; j1 = true;
                caban.GetComponentInChildren<KabanCol>().enabled = false;
                olen1.GetComponentInChildren<umniolen>().enabled = false;
                olen1.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                if (!olen1.GetComponent<Animation>().IsPlaying("hornAttack1"))
                    olen1.GetComponent<Animation>().Play("hornAttack1");
                if (!caban.GetComponent<Animation>().IsPlaying("death"))
                    caban.GetComponent<Animation>().Play("death");
            }
            else if (other.tag == "Olen2")
            {
                k2 = 0; j2 = true;
                caban.GetComponentInChildren<KabanCol>().enabled = false;
                olen2.GetComponentInChildren<umniolen>().enabled = false;
                olen2.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                if (!olen2.GetComponent<Animation>().IsPlaying("hornAttack1"))
                    olen2.GetComponent<Animation>().Play("hornAttack1");
                if (!caban.GetComponent<Animation>().IsPlaying("death"))
                    caban.GetComponent<Animation>().Play("death");
            }
            else if (other.tag == "Olen3")
            {
                k3 = 0; j3 = true;
                caban.GetComponentInChildren<KabanCol>().enabled = false;
                olen3.GetComponentInChildren<umniolen>().enabled = false;
                olen3.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                if (!olen3.GetComponent<Animation>().IsPlaying("hornAttack1"))
                    olen3.GetComponent<Animation>().Play("hornAttack1");
                if (!caban.GetComponent<Animation>().IsPlaying("death"))
                    caban.GetComponent<Animation>().Play("death");


            }
            else if (other.tag == "Olen4")
            {
                k4 = 0; j4 = true;
                caban.GetComponentInChildren<KabanCol>().enabled = false;
                olen4.GetComponentInChildren<umniolen>().enabled = false;
                olen4.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                if (!olen4.GetComponent<Animation>().IsPlaying("hornAttack1"))
                    olen4.GetComponent<Animation>().Play("hornAttack1");
                if (!caban.GetComponent<Animation>().IsPlaying("death"))
                    caban.GetComponent<Animation>().Play("death");

            }
        }

    

        // Update is called once per frame
        void Update()
        {
            if (caban.GetComponent<Animation>().IsPlaying("death"))
            {
                if (j == true) { k++; }
                else if (j1 == true) { k1++; }
                else if (j2 == true) { k2++; }
                else if (j3 == true) { k3++; }
                else if (j4 == true) { k4++; }
                if (jj == true) { kk++; }
                else if (jj1 == true) { kk1++; }
                else if (jj2 == true) { kk2++; }
                else if (jj3 == true) { kk3++; }
                else if (jj4 == true) { kk4++; }
            }
            if ((k > 50) && (k < 52)) 
            {
                caban.GetComponent<Transform>().position = spawn.transform.position;
                bear.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                bear.GetComponent<NaMesh>().target = bear.GetComponentInChildren<IntellectCol>().home;
                bear.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                bear.GetComponent<Animation>().Play("walk");
                caban.GetComponentInChildren<KabanCol>().enabled = true;
                bear.GetComponentInChildren<IntellectCol>().enabled = true;
                k++; j = false;
            }
            if ((k1 > 50) && (k1 < 52))
            {
                caban.GetComponent<Transform>().position = spawn.transform.position;
                bear1.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                bear1.GetComponent<NaMesh>().target = bear1.GetComponentInChildren<IntellectCol>().home;
                bear1.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                bear1.GetComponent<Animation>().Play("walk");
                caban.GetComponentInChildren<KabanCol>().enabled = true;
                bear1.GetComponentInChildren<IntellectCol>().enabled = true;
                k1++; j1 = false;
            }
            if ((k2 > 50) && (k2 < 52))
            {
                caban.GetComponent<Transform>().position = spawn.transform.position;
                bear2.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                bear2.GetComponent<NaMesh>().target = bear2.GetComponentInChildren<IntellectCol>().home;
                bear2.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                bear2.GetComponent<Animation>().Play("walk");
                caban.GetComponentInChildren<KabanCol>().enabled = true;
                bear2.GetComponentInChildren<IntellectCol>().enabled = true;
                k2++; j2 = false;
            }
            if ((k3 > 50) && (k3 < 52))
            {
                caban.GetComponent<Transform>().position = spawn.transform.position;
                bear3.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                bear3.GetComponent<NaMesh>().target = bear3.GetComponentInChildren<IntellectCol>().home;
                bear3.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                bear3.GetComponent<Animation>().Play("walk");
                caban.GetComponentInChildren<KabanCol>().enabled = true;
                bear3.GetComponentInChildren<IntellectCol>().enabled = true;
                k3++; j3 = false;
            }
            if ((k4 > 50) && (k4 < 52))
            {
                caban.GetComponent<Transform>().position = spawn.transform.position;
                bear4.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                bear4.GetComponent<NaMesh>().target = bear4.GetComponentInChildren<IntellectCol>().home;
                bear4.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                bear4.GetComponent<Animation>().Play("walk");
                caban.GetComponentInChildren<KabanCol>().enabled = true;
                bear4.GetComponentInChildren<IntellectCol>().enabled = true;
                k4++; j4 = false;
            }


            if ((kk > 50) && (kk < 52))
            {
                caban.GetComponent<Transform>().position = spawn.transform.position;
                olen.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                olen.GetComponent<NaMesh>().target = olen.GetComponentInChildren<umniolen>().gulat;
                olen.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                olen.GetComponent<Animation>().Play("walk");
                caban.GetComponentInChildren<KabanCol>().enabled = true;
                olen.GetComponentInChildren<umniolen>().enabled = true;
                kk++; jj = false;
            }
            if ((kk1 > 50) && (kk1 < 52))
            {
                caban.GetComponent<Transform>().position = spawn.transform.position;
                olen1.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                olen1.GetComponent<NaMesh>().target = olen1.GetComponentInChildren<umniolen>().gulat;
                olen1.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                olen1.GetComponent<Animation>().Play("walk");
                caban.GetComponentInChildren<KabanCol>().enabled = true;
                olen1.GetComponentInChildren<umniolen>().enabled = true;
                kk1++; jj1 = false;
            }
            if ((kk2 > 50) && (kk2 < 52))
            {
                caban.GetComponent<Transform>().position = spawn.transform.position;
                olen2.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                olen2.GetComponent<NaMesh>().target = olen2.GetComponentInChildren<umniolen>().gulat;
                olen2.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                bear2.GetComponent<Animation>().Play("walk");
                caban.GetComponentInChildren<KabanCol>().enabled = true;
                olen2.GetComponentInChildren<umniolen>().enabled = true;
                kk2++; jj2 = false;
            }
            if ((kk3 > 50) && (kk3 < 52))
            {
                caban.GetComponent<Transform>().position = spawn.transform.position;
                olen3.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                olen3.GetComponent<NaMesh>().target = olen3.GetComponentInChildren<umniolen>().gulat;
                olen3.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                olen3.GetComponent<Animation>().Play("walk");
                caban.GetComponentInChildren<KabanCol>().enabled = true;
                olen3.GetComponentInChildren<umniolen>().enabled = true;
                kk3++; jj3 = false;
            }
            if ((kk4 > 50) && (kk4 < 52))
            {
                caban.GetComponent<Transform>().position = spawn.transform.position;
                olen4.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                caban.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                olen4.GetComponent<NaMesh>().target = olen4.GetComponentInChildren<umniolen>().gulat;
                olen4.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3;
                olen4.GetComponent<Animation>().Play("walk");
                caban.GetComponentInChildren<KabanCol>().enabled = true;
                olen4.GetComponentInChildren<umniolen>().enabled = true;
                kk4++; jj4 = false;
            }
        }
    }
}

