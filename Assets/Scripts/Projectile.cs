using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Projectile : MonoBehaviour
{
    public List<GameObject> throwables;

    bool InHand = true;
    bool Wait = false;
    float Force;
    float Lift;
    public Transform spawnPos;
    float SpawnAfter;
    GameObject throwable;

    GameObject currThrowable;

    void Start()
    {
        setThrowable(throwables[0].GetComponent<Throwable>());
        Spawn();
    }

    void setThrowable(Throwable changeTo)
    {
        Force = changeTo.Force;
        Lift = changeTo.Lift;
        SpawnAfter = changeTo.SpawnAfter;
        throwable = changeTo.gameObject;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && InHand)
        {
            currThrowable.GetComponent<Rigidbody>().isKinematic = false;
            currThrowable.GetComponent<Rigidbody>().AddForce((Camera.main.transform.forward+Vector3.up*Lift)*Force,ForceMode.Impulse);
            currThrowable.transform.SetParent(null);
            currThrowable.GetComponent<Throwable>().inAir = true;
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
        currThrowable = Instantiate(throwable,spawnPos.position,Quaternion.identity);
        currThrowable.transform.rotation = spawnPos.rotation;
        currThrowable.GetComponent<Rigidbody>().isKinematic = true;
        currThrowable.transform.parent = Camera.main.transform;
        currThrowable.transform.rotation = transform.rotation;
        InHand = true;
        Wait = false;

    }
}
