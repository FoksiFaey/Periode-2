using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour {
    private RaycastHit hit;
    public GameObject particle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.DrawRay(transform.position,transform.forward*1000,Color.red);
        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 1000f))
            {
                GameObject g = Instantiate(particle, hit.point, Quaternion.identity);
                Destroy(g, 1);
                if (hit.transform.tag == "Footballl")
                {
                    
                    
                    hit.transform.gameObject.GetComponent<HealthScript>().LoseHP(1);

                }
            }
        }
        
	}
}
