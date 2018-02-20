using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Type1 : WalkScript {
    public float rotation;
    public Vector3 rotate;
	// Use this for initialization
	void Start () {
		
	}

    void Update()
    {
        Walk();
        DoSpecial();
    }

    // Update is called once per frame
    public override void DoSpecial () {
        transform.Rotate(rotate * Time.deltaTime * rotation);
	}
}
