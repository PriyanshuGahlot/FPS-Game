using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Fan : MonoBehaviour
{
    public Transform toRotate;
    public float rotationSpeed;

    private void FixedUpdate()
    {
        toRotate.Rotate(new Vector3(0, Time.deltaTime * rotationSpeed, 0));
    }
}
