using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustTest : MonoBehaviour {
    public float endDmg;

	// Use this for initialization
	void Start () {
        endDmg = DamgBuff(10, 50);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public float DamgBuff (float damage, float dmgMultiplier)
    {
        return damage * dmgMultiplier;
    }
}
