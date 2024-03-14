using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : MonoBehaviour
{

    Throwable This;
    
    // Start is called before the first frame update
    void Start()
    {
        This = GetComponent<Throwable>();
        transform.forward = ((Camera.main.transform.forward + Vector3.up * This.Lift) * This.Force).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(This.inAir);
        if(transform.GetComponent<Throwable>().inAir) transform.forward = transform.GetComponent<Rigidbody>().velocity.normalized;
    }


    private void OnCollisionEnter(Collision collision)
    {
        
    }

}
