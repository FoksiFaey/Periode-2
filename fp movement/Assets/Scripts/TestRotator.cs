using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotator : MonoBehaviour
{
    public Vector3 rotate;


    public Vector3 view;
    public GameObject cam;
    public Vector3 camlook;


    public float sensetivety;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

       
        camlook.x = -Input.GetAxis("Mouse Y");
        transform.Rotate(view * sensetivety);
        cam.transform.Rotate(camlook * sensetivety);
        camlook.x = Mathf.Clamp(camlook.x, -50.0f, 50.0f);
        
    }
}
    