using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float speed=5f;
    public GameObject PointAxis;
    bool touched = false;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!touched)
        { 
        transform.RotateAround(PointAxis.transform.position, Vector3.forward, speed);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       touched = true;


    }
}
