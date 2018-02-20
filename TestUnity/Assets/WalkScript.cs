using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkScript : MonoBehaviour {
    public float Speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Walk () {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
	}
    public virtual void DoSpecial()
    {

    }
}
