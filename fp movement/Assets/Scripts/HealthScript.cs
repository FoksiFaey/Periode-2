using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour {
    public int hp;
    public GameObject enemy;
    public Vector3 spawnRange;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (hp <= 0)
        {
            spawnRange.x = Random.Range(4, 12);
            spawnRange.z = Random.Range(4, 12);
            Instantiate(enemy, spawnRange, Quaternion.identity);
            hp = Random.Range(4, 10);
            Destroy(gameObject);
        }
    }
    public void LoseHP(int dmg)
    {
        hp -= dmg;
        
    }
}
