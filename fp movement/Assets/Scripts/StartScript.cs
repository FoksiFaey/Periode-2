using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour {
    public GameObject player;
    public GameObject startCam;
    public GameObject button1;
    public GameObject button2;
    // Use this for initialization
    void Start()
     {
        player.SetActive(false);
     }
    
        
    
	
	// Update is called once per frame
	public void StartGame ()
    {
        player.SetActive(true);
        startCam.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
	}
}
