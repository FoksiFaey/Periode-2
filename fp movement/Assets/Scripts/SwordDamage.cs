using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordDamage : MonoBehaviour
{
    public GameObject particle;
    public bool startSlash;
    public float timr;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject.Find("AniSword").GetComponent<Animator>().SetBool("Slash", true);
            startSlash = true;
        }

        if (startSlash == true)
        {
            timr += Time.deltaTime;
            if (timr >= 1.2f)
            {
                startSlash = false;
                timr = 0;
            }
        }
        
        if (Input.GetButtonUp("Fire1"))
        {
            
            GameObject.Find("AniSword").GetComponent<Animator>().SetBool("Slash", false);
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (startSlash == true)
        {
            GameObject g = Instantiate(particle, other.transform.position, Quaternion.identity);  
             Destroy(g, 1);
             if (other.gameObject.tag == "Enemy")
             {
              other.gameObject.GetComponent<HealthScript>().LoseHP(1);
             }
        }
    }
}