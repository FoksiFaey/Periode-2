using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotator : MonoBehaviour
{
    public Vector3 rotate;
    public float x;
    public float z;
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
        view.y = Input.GetAxis("Mouse X");
        camlook.x = -Input.GetAxis("Mouse Y");
        transform.Rotate(view * sensetivety);
        cam.transform.Rotate(camlook * sensetivety);
        if (cam.transform.eulerAngles.x > 60)
        {
            if (cam.transform.eulerAngles.x < 180)
            {
                cam.transform.eulerAngles = new Vector3(59.9999f, cam.transform.eulerAngles.y, cam.transform.eulerAngles.z);
            }
        }
        if (cam.transform.eulerAngles.x < 300)
        {
            if (cam.transform.eulerAngles.x > 180)
            {
                cam.transform.eulerAngles = new Vector3(300.0001f, cam.transform.eulerAngles.y, cam.transform.eulerAngles.z);
            }
        }


    }
}
    