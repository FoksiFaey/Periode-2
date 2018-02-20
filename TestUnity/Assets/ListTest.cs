using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTest : MonoBehaviour {
    public List<GameObject> b = new List<GameObject>();
    public GameObject g;
    public Vector3 h;
    public int resolution;

    private void Start()
    {
        for (int t = 0; t < resolution; t++)
        {
            for (int i = 0; i < resolution; i++)
            {
                for (int c = 0; c < resolution; c++)
                {
                    h = new Vector3((float)c, (float)i, (float)t);
                    b.Add(Instantiate(g, h, Quaternion.identity));
                }
            }
        }

    }

}
