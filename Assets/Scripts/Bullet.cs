using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;

    private void OnTriggerEnter(Collider other)
    {
        Enemy curr = other.GetComponent<Enemy>();
        if (curr != null)
        {
            curr.health -= damage;
        }
        Destroy(transform.gameObject);
    }
}
