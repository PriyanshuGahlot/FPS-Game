using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float walk;
    [SerializeField] private float run;
    private float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = walk+run;
        }
        else { speed = walk;}
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3 (0f,0f,speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3 (0f,0f,-speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3 (-speed,0f,0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3 (speed,0f,0f);
        }

    }
}
