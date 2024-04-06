using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public bool aroundX;
    public bool aroundY;
    public bool aroundZ;
    public float RoationSpeed;

    private void FixedUpdate()
    {
        if (aroundX)
        {
            transform.Rotate(Vector3.right, Time.fixedDeltaTime * RoationSpeed);
        }
        if (aroundY)
        {
            transform.Rotate(Vector3.up, Time.fixedDeltaTime * RoationSpeed);
        }
        if (aroundZ)
        {
            transform.Rotate(Vector3.forward, Time.fixedDeltaTime * RoationSpeed);
        }
    }

}
