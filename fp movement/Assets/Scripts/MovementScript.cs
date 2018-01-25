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
    public Vector3 camlook;
    public Vector3 reset;
    // Use this for initialization
    void Start () {
		Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(move * Time.deltaTime * speed);
        if (Input.GetButtonDown("Fire1"))
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        
        if (Input.GetButton("Escape"))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        x = Input.GetAxis("Vertical");
        z = Input.GetAxis("Horizontal");
        move.x = z;
        move.z = x;
        if (b == true)
        {
            if (Input.GetButtonDown("Jump") == true)
            {
                r.velocity = height;
                b = false;
            }
        }
        if (Input.GetButtonDown("Shift"))
        {
            speed *= 2f;
        }
        if (Input.GetButtonUp("Shift"))
        {
            speed /= 2f;
        }
        if (transform.position.y <= -20)
        {
            reset.y = 10;
            transform.position = reset;
            print(transform.position);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        b = true;
    }
  
}


