using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nonRaycastGun : MonoBehaviour
{
    public Transform shootFrom;
    public float bulletSpeed;
    public bool hasGravity;
    public GameObject bullet;


    private void Update()
    {
        if(Input.GetButtonDown("Fire 1"))
        {
            GameObject curr = Instantiate(bullet, shootFrom.position, Quaternion.identity);
            curr.GetComponent<Rigidbody>().useGravity = hasGravity;
            curr.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
        }
    }

}
