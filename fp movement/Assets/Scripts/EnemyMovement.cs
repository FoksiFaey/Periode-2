using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {
    NavMeshAgent agent14;
    public Transform target;
	// Use this for initialization
	void Start ()
    {
        agent14 = this.GetComponent<NavMeshAgent>();
	}
	// Update is called once per frame
	void Update ()
    {
       
	}
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            target = other.transform;
            agent14.SetDestination(target.position);
        }
    }
}
 //RicardoHEEFTgeholpen