using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    NavMeshAgent agent14;
    private Transform target;
    private float timr;
    public bool time;
    public AudioSource WalkSound;

    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        agent14 = this.GetComponent<NavMeshAgent>();
    }
    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        GetComponent<AudioSource>().mute = false;
        if (time == true)
        {
            timr += Time.deltaTime;
        }
        if (other.tag == "Player")
        {
            target = other.transform;
            agent14.SetDestination(target.position);
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        GetComponent<AudioSource>().mute = true;
    }
    private void OnCollisionEnter(Collision Collider)
    {
        if (Collider.gameObject.tag == "Player")
        {
            time = true;
            Collider.gameObject.GetComponent<PlayerHealth>().health -= 1;
            gameObject.GetComponent<NavMeshAgent>().stoppingDistance = 5;
            if (timr == 2f)
            {
                gameObject.GetComponent<NavMeshAgent>().stoppingDistance = 0;
                timr = 0;
                time = false;
            }
        }
    }
}
