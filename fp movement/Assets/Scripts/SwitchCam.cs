using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCam : MonoBehaviour
{
    public GameObject cam;
    public GameObject camPos1;
    public GameObject camPos2;
    public int count;
    public GameObject player;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("CharInside");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Camera"))
        {
            count += 1;
        }

        if (count == 0)
        {
            cam.transform.position = camPos1.transform.position;
            player.SetActive(false);
        }
        if (count == 1)
        {
            cam.transform.position = camPos2.transform.position;
            player.gameObject.SetActive(true);
        }
        if (count == 2)
        {
            count = 0;
        }
    }
}