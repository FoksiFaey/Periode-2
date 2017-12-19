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

        view.y = Input.GetAxis("Mouse X");
        camlook.x = -Input.GetAxis("Mouse Y");
        transform.Rotate(view * sensetivety);
        cam.transform.Rotate(camlook * sensetivety);
        camlook.x = Mathf.Clamp(camlook.x, -5000.0f, 5000.0f);
        transform.eulerAngles = (new Vector3(camlook.x, transform.eulerAngles.y, 0.0f));
    }
}
    