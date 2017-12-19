using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {
    public float speed;
    public Vector3 move;
    public float x;
    public float z;
    public Rigidbody r;
    public bool b;
    public Vector3 height;
    public Vector3 view;
    public GameObject cam;
    public Vector3 camlook;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        view.y = Input.GetAxis("Mouse X");
        transform.eulerAngles = (new Vector3(camlook.x, transform.eulerAngles.y, 0.0f));
        transform.Translate(move * Time.deltaTime * speed);
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        move.x = x;
        move.z = z;
        if (b == true)
        {
            if (Input.GetButtonDown("Jump") == true)
            {
                r.velocity = height;
                b = false;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        b = true;
    }
}


