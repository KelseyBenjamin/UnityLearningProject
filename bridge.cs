using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridge : MonoBehaviour
{
    public GameObject Bridge;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float height = Bridge.transform.position.y;
        if (Input.GetKey(KeyCode.B) && Input.GetKey(KeyCode.DownArrow)&& height > -3.55)
            {
            Bridge.transform.position += new Vector3(0, -0.01f, 0);
        }
        if (Input.GetKey(KeyCode.B) && Input.GetKey(KeyCode.UpArrow)&& height < 0.13)
        {
            Bridge.transform.position += new Vector3(0, 0.01f, 0);
        }
    }
}
