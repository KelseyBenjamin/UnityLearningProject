using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridge : MonoBehaviour
{
    public GameObject Bridge;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Bridge.transform.position += new Vector3(0, -0.1f, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Bridge.transform.position += new Vector3(0, 0.1f, 0);
        }
    }
}
