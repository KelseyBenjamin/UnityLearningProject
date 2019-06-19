using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightingforcube : MonoBehaviour
{
    Light cubeLight;
    // Start is called before the first frame update
    void Start()
    {
        cubeLight = GetComponent<Light> ();
    }

    // Update is called once per frame
    void Update()
    {
      //  if (Input.GetKeyUp(KeyCode.Space))
        {
            //cubeLight.enabled = !cubeLight.enabled;
        }
    }
    public void toggleLights()
    {
        cubeLight.enabled = !cubeLight.enabled;
    }
}
