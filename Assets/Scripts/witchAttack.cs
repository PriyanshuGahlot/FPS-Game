using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witchAttack : MonoBehaviour
{
    public float lifeTime;
    public float movementSpeed;
    public float sizeUpSpeed;

    Rigidbody rb;
    Vector3 vel;
    float currSize;

    private void Start()
    {
        currSize = 0;
        transform.localScale = Vector3.zero;
        rb = GetComponent<Rigidbody>();
        vel = Camera.main.transform.forward * movementSpeed;
    }


    private void FixedUpdate()
    {
        lifeTime -= Time.fixedDeltaTime;
        if (lifeTime <= 0) Destroy(transform.gameObject);
        rb.velocity = vel;
        //updateing size
        transform.localScale = Vector3.one * currSize;
        if(currSize<1) currSize += Time.fixedDeltaTime * sizeUpSpeed;
        currSize = Mathf.Clamp(currSize,0,1);
    }
}
