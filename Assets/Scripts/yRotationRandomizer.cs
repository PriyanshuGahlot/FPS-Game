using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class yRotationRandomizer : MonoBehaviour
{
    public float x;
    public float z;
    void Start()
    {
        System.Random rand = new System.Random();
        float y = rand.Next(360);
        transform.rotation = Quaternion.Euler(new Vector3(x, y, z));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
