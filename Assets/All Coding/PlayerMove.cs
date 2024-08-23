using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 1000f;
    public float xx = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, force * Time.deltaTime);
        

        if (Input.GetKey("a"))
        {
            rb.AddForce(-xx * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(xx * Time.deltaTime, 0, 0);
        }
    }
}
