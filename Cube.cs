using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private float myAngle = 0.0f;
    public float spinSpeed = 100.0f;
    public float flyupSpeed = 0.5f;

    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Renderer>().material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Renderer>().material.color = color;


// Code from website
        myAngle += 1.0f;

        if (myAngle > 360.0f)
            myAngle -= 360.0f;



        //This keeps infinitely moving up
        transform.Translate( 0.0f, Mathf.Sin(myAngle * Mathf.PI / 180.0f) * flyupSpeed * Time.deltaTime, 0.0f);
        

        //This spins the gameobject clockwise and counterclockwise as it moves up.
        //If you want the object to only spin one direction, use Mathf.Abs(Mathf.Sin(...)) below
        transform.Rotate(Vector3.up, Mathf.Sin(myAngle * Mathf.PI / 180.0f) * spinSpeed * Time.deltaTime);

    }
}
