using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    public float Force;
    public float Lift;
    public float Damage;

    public GameObject throwable;
    public Transform WeaponOffset;
    public float SpawnAfter;

    bool InHand = true;
    bool Wait = false;

    GameObject currThrowable;
    


    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetMouseButtonDown(0) && InHand)
        {
            currThrowable.GetComponent<Rigidbody>().isKinematic = false;
            currThrowable.GetComponent<Rigidbody>().AddForce((Camera.main.transform.forward+Vector3.up*Lift)*Force,ForceMode.Impulse);
            currThrowable.transform.SetParent(null);
            InHand = false;
            Wait = false;
            
        }
        if (!InHand && !Wait)
            {
                Invoke("Spawn",SpawnAfter);
                Wait = true;

            }


    }

    void Spawn()
    {
        currThrowable = Instantiate(throwable,WeaponOffset.position,Quaternion.identity);
        currThrowable.GetComponent<Rigidbody>().isKinematic = true;
        currThrowable.transform.parent = Camera.main.transform;
        currThrowable.transform.rotation = transform.rotation;
        InHand = true;
        Wait = false;

    }
}
