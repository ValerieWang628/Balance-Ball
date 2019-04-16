using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movSpeed = 1000f;
    public float jumpOffset = 10f;
    //public float movForce = 300f;
    Rigidbody rb;
    PlayerMovement pm;
    // Start is called before the first frame update
    void Start()
    {
        jumpOffset = 10f;
        rb = GetComponent<Rigidbody>();
        pm = GetComponent<PlayerMovement>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(movSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-movSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, movSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
        }
    }

    //void Update()
    //{
    //    //if (Input.GetKey("space"))
    //    //{
    //    //    rb.AddForce(0, jumpOffset * movSpeed * Time.deltaTime, 0);
    //    //}

    //}
}