using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HealthScript : MonoBehaviour {
    public int hp;
    public GameObject enemy;
    public Vector3 spawnRange;
    NavMeshAgent agent15;
    // Use this for initialization
    void Start () {
        agent15 = this.GetComponent<NavMeshAgent>();
        
    }
	
	// Update is called once per frame
	void Update () {

    }
    public void LoseHP(int dmg)
    {
        hp -= dmg;
        if (hp <= 0)
        {
            hp = Random.Range(4, 10);
            spawnRange.x = Random.Range(-20, 20);
            spawnRange.z = Random.Range(-20, 20);
            print(spawnRange);
            Instantiate(enemy, transform.position + spawnRange, Quaternion.identity);
            Instantiate(enemy, transform.position + spawnRange, Quaternion.identity);
            agent15.isStopped = true;
            Destroy(gameObject);
        }
    }
}
