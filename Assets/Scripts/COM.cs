using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COM : MonoBehaviour
{
public Transform com;

    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<Rigidbody>().centerOfMass = com.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
